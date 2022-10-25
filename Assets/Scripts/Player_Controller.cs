using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    private Rigidbody2D rb;
    private Transform playertransform;
    private float spedometer = 0.004f;
    public static int i, altitude,velo, charges = 3, limit = 40, multiplier = 30;
    // limit (the speed limit that the spaceship can withstand when ascending and descending)
    // charges (the number of jumps the scapeship has)
    // multiplier (the number multiplied with the power that thrusts away the spaceship)

    void Start()
    {
        StartCoroutine(Launch());
        rb = GetComponent<Rigidbody2D>();
        playertransform = GetComponent<Transform>();
    }

    void Update()
    {   
        if(playertransform != null)
        //verifica daca mai exista obiectul
        {

        altitude = (int)transform.position.y;
        velo = (int)rb.velocity.y;

        if ( velo > limit)
            Destroy(gameObject);
        else if ( velo < -limit)
            Destroy(gameObject);

        }
    }
    
    IEnumerator Launch()
    {
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
