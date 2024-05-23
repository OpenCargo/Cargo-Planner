using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPlacement : MonoBehaviour
{
    BuildManager buildManager;

    void Start()
    {
        buildManager = GameObject.Find("BuildManager").GetComponent<BuildManager>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pallet"))
        {
            buildManager.canPlace = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Pallet"))
        {
            buildManager.canPlace = true;
        }
    }
}
