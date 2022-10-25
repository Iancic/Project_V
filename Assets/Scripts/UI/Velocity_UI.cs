using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Velocity_UI : MonoBehaviour
{
    public Text velo;

    void Start()
    {
        velo = GetComponent<Text> ();
    }

    void Update()
    {
        velo.text = Player_Controller.velo.ToString() + " m/s";
    }
}
