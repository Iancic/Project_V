using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Limit_UI : MonoBehaviour
{
    public Text limit;

    void Start()
    {
        limit = GetComponent<Text> ();
    }

    void Update()
    {
        limit.text = "limit at " + Player_Controller.limit.ToString() + " m/s";
    }
}
