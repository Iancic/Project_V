using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Charges_UI : MonoBehaviour
{
    public Text charges;

    void Start()
    {
        charges = GetComponent<Text> ();
    }

    void Update()
    {
        charges.text = "charges left " + Player_Controller.charges.ToString();
    }
}
