using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TMP_InputField lengthInput;
    [SerializeField] private TMP_InputField widthInput;
    [SerializeField] private TMP_InputField heigthInput;
    [SerializeField] private CargoItem myCargoItem;
    [SerializeField] private VerticalLayoutGroup myCargo;
    void Start()
    {

    }

    void Update()
    {

    }

    public void Add()
    {
        //Debug.Log(lengthInput.text);
       // Debug.Log(widthInput.text);
        //Debug.Log(heigthInput.text);
        CargoItem newCargoItem = Instantiate(myCargoItem);
        newCargoItem.transform.SetParent(myCargo.transform);
        newCargoItem.GetComponent<TextMeshProUGUI>().text = lengthInput.text + " x " + widthInput.text + " x " + heigthInput.text;
        newCargoItem.GetComponent<CargoItem>().pallet.palletLength = float.Parse(lengthInput.text);
        newCargoItem.GetComponent<CargoItem>().pallet.palletWidth = float.Parse(widthInput.text);
        newCargoItem.GetComponent<CargoItem>().pallet.palletHeigth = float.Parse(heigthInput.text);
    }
}
