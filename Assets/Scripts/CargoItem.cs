using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CargoItem : MonoBehaviour
{
    public Pallet pallet;
    public TextMeshProUGUI amount;
    void Start()
    {
        amount.text = pallet.palletAmount + "";
        transform.localScale = new Vector3(1, 1, 1);
    }

    void Update()
    {
        amount.text = pallet.palletAmount + "";
    }

    public void SelectedPallet()
    {
        BuildManager.selectedPallet = pallet;
        BuildManager.selectedCargoItem = this.gameObject;
    }
}
