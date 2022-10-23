using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Launch_UI : MonoBehaviour
{
    public Text score;

    void Start()
    {
        score = GetComponent<Text> ();
    }

    void Update()
    {
        score.text = Player_Controller.i.ToString() + " newtons";
    }
}
