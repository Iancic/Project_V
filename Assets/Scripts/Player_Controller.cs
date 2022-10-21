using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    private Rigidbody2D rb;
    public float thrust;
    public int charges = 300;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
         if (Input.GetKeyDown(KeyCode.Q) && charges > 0)
            {
                rb.AddForce(new Vector2 (0f, thrust));
                charges = charges -1;

            }
    }
}
