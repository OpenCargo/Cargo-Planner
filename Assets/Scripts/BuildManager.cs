using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public Vector3 pos;
    private RaycastHit hit;
    public static Pallet selectedPallet;
    private Pallet pendingPallet;
    [SerializeField] private LayerMask layerMask;

    void Start()
    {

    }

    private void Update()
    {
        if (pendingPallet != null)
        {
            pendingPallet.transform.position = pos;
            if (Input.GetMouseButtonDown(0))
            {
                PlacePallet();
            }
        }

        if (selectedPallet == null)
        {
            return;
        }
        else
        {
            pendingPallet = Instantiate(selectedPallet, pos, transform.rotation);
            selectedPallet = null;
        }
    }

    public void PlacePallet()
    {
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

}
