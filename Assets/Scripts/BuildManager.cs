using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR;

public class BuildManager : MonoBehaviour
{
    public Vector3 pos;
    private RaycastHit hit;
    public static Pallet selectedPallet;
    private Pallet pendingPallet;
    [SerializeField] private LayerMask layerMask;

    [SerializeField] private float gridSize;
    private bool isGridOn = true;
    [SerializeField] private Toggle gridToggle;
    [SerializeField] private float rotateAmount;
    [SerializeField] private Material[] materials;
    public bool canPlace;
    void Start()
    {
        canPlace = true;
    }

    private void Update()
    {
        if (pendingPallet != null)
        {
            float palletHeight = pendingPallet.palletHeigth;
            if (isGridOn)
            {
                pendingPallet.transform.position = new Vector3(RoundToNearestGrid(pos.x), pos.y + (float)(((palletHeight-1)/100)/2), RoundToNearestGrid(pos.z));
            }
            else
            {
                pos.y = (float)(((palletHeight - 1)/100)/2);
                pendingPallet.transform.position = pos;
            }

            if (Input.GetMouseButtonDown(0) && canPlace)
            {
                PlacePallet();
            }
            if (Input.GetKeyDown(KeyCode.R))
            {
                RotatePallet();
            }
            UpdateMaterials();
        }

        if (selectedPallet == null)
        {
            return;
        }
        else
        {
            pos.y = (float)(((selectedPallet.palletHeigth - 1) / 100) / 2);
            pendingPallet = Instantiate(selectedPallet, pos, transform.rotation);
            selectedPallet = null;
        }

    }

    public void PlacePallet()
    {
        pendingPallet.GetComponent<MeshRenderer>().material = materials[2];
        pendingPallet.gameObject.layer = 3;
        pendingPallet = null;
    }

    void FixedUpdate()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, 1000, layerMask))
        {
            pos = hit.point;
        }

    }
    public void ToggleGrid()
    {
        if (gridToggle.isOn)
            isGridOn = true;
        else
            isGridOn = false;
    }

    float RoundToNearestGrid(float pos)
    {
        float xDiff = pos % gridSize;
        pos -= xDiff;
        if (xDiff > (gridSize / 2))
        {
            pos += gridSize;
        }
        return pos;
    }

    public void RotatePallet()
    {
        pendingPallet.transform.Rotate(Vector3.up, rotateAmount);
    }

    private void UpdateMaterials()
    {
        if (pendingPallet != null)
        {
            if (canPlace)
            {
                pendingPallet.GetComponent<MeshRenderer>().material = materials[0];
            }
            if (!canPlace)
            {
                pendingPallet.GetComponent<MeshRenderer>().material = materials[1];
            }
        }
    }

}
