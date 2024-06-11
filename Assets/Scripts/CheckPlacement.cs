using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
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
        if (other.gameObject.CompareTag("Pallet") || other.gameObject.CompareTag("Trailer"))
        {
            buildManager.canPlace = false;
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Trailer"))
        {
            buildManager.canPlace = false;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Pallet") || other.gameObject.CompareTag("Trailer"))
        {
            buildManager.canPlace = true;
        }
    }
}
