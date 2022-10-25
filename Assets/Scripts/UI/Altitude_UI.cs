using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Altitude_UI : MonoBehaviour
{
    public Text altitude;

    void Start()
    {
        altitude = GetComponent<Text> ();
    }

    void Update()
    {
        altitude.text = Player_Controller.altitude.ToString() + " meters";
    }
}
