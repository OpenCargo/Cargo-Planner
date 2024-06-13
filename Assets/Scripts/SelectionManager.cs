using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionManager : MonoBehaviour
{
    private GameObject selectedPallet;
    [SerializeField] private Material selectionMaterial;
    [SerializeField] private LayerMask layerMask;
    [SerializeField] private Material defaultPalletMaterial;
    void Update()
    {
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 1000, layerMask))
        {
            var selection = hit.collider.gameObject;
            if (selection.CompareTag("Pallet"))
            {
                //Debug.Log("Pallet hit");
                selectedPallet = selection;
                selectedPallet.GetComponent<MeshRenderer>().material = selectionMaterial;
            }
            else
            {
                if (selectedPallet != null)
                {
                    selectedPallet.GetComponent<MeshRenderer>().material = defaultPalletMaterial;
                    selectedPallet = null;
                }
                return;
            }
        }

    }
}
