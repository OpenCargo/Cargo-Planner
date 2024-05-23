using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CargoItem : MonoBehaviour
{
    [SerializeField] public Pallet pallet;

    void Start()
    {

    }

    void Update()
    {

    }

    public void SelectedPallet()
    {
        
        BuildManager.selectedPallet = pallet;
    }
}
