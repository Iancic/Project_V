using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextBoost : MonoBehaviour
{
    public Text score;

    void Start()
    {
        score = GetComponent<Text> ();
    }

    void Update()
    {
        score.text = "Power " + Player_Controller.i;
    }
}
