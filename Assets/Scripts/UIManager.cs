using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI lengthInput;
    [SerializeField] private TextMeshProUGUI widthInput;
    [SerializeField] private TextMeshProUGUI heigthInput;
    [SerializeField] private GameObject myCargoItem;
    [SerializeField] private VerticalLayoutGroup myCargo;
    void Start()
    {

    }

    void Update()
    {

    }

    public void Add()
    {
        GameObject newCargoItem = Instantiate(myCargoItem);
        newCargoItem.transform.SetParent(myCargo.transform);
        newCargoItem.GetComponent<TextMeshProUGUI>().text = lengthInput.text + " x " + widthInput.text + " x " + heigthInput.text;
    }
}
