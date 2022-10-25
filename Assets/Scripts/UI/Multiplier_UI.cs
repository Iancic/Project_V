using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Multiplier_UI : MonoBehaviour
{
    public Text multiplier;

    void Start()
    {
        multiplier = GetComponent<Text> ();
    }

    void Update()
    {
        multiplier.text = " x " + Player_Controller.multiplier.ToString() + " newtons";
    }
}
