using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pallet : MonoBehaviour
{
    [HideInInspector] public float palletWidth;
    [HideInInspector] public float palletLength;
    [HideInInspector] public float palletHeigth;

    void Start()
    {
        transform.localScale = new Vector3((float)palletWidth / 100, (float)palletHeigth / 100, (float)palletLength / 100);
    }

    void Update()
    {

    }

    
}
