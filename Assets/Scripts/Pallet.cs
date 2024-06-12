using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Pallet : MonoBehaviour
{
    [HideInInspector] public float palletWidth;
    [HideInInspector] public float palletLength;
    [HideInInspector] public float palletHeigth;
    [HideInInspector] public float palletAmount;
    [SerializeField] private Canvas canvas;
    [SerializeField] private TextMeshProUGUI[] dimensionsText;

    void Start()
    {
        transform.localScale = new Vector3((float)((palletWidth - 1) / 100), (float)((palletHeigth - 1) / 100), (float)((palletLength - 1) / 100));
        GetComponent<BoxCollider>().size = new Vector3(1, 1, 1);
        foreach (var text in dimensionsText)
        {
            text.text = palletLength + " x " + palletWidth + " x " + palletHeigth;

        }

    }

    void Update()
    {

    }


}
