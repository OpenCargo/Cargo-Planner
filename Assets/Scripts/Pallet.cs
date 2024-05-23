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
        transform.localScale = new Vector3((float)palletWidth *0.99f/ 100, (float)palletHeigth * 0.99f / 100, (float)palletLength * 0.99f / 100);
        GetComponent<BoxCollider>().size = new Vector3(1,1,1);
    }

    void Update()
    {

    }

    
}
