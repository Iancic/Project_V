using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    private Rigidbody2D rb;
    public float multiplier = 100, spedometer;
    public static int i, altitude,velo, charges = 2;

    void Start()
    {
        StartCoroutine(Launch());
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        altitude = (int)transform.position.y;
        velo = (int)rb.velocity.y;
        Debug.Log(velo);
    }
    
    IEnumerator Launch()
    {
        charges = 2;
        do
        {
        for (i=1; i<100; i++){
            if (Input.GetKeyDown(KeyCode.Q) && charges != 0)
            {
                charges = charges - 1;
                rb.AddForce(new Vector2 (0f, i * multiplier));
            }
            yield return new WaitForSeconds(spedometer);}
        {
            for (i=100; i>0; i--){
            if (Input.GetKeyDown(KeyCode.Q) && charges != 0)
            {
                charges = charges - 1;
                rb.AddForce(new Vector2 (0f, i * multiplier));
            }
            yield return new WaitForSeconds(spedometer);}
        }
        }while (charges != 0);
        
    }
}
