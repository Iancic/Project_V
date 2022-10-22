using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    private Rigidbody2D rb;
    public float multiplier = 100, spedometer;
    public static int i;
    public int launched = 0;

    void Start()
    {
        StartCoroutine(Launch());
        rb = GetComponent<Rigidbody2D>();
    }
    
    IEnumerator Launch()
    {
        launched = 0;
        do
        {
        for (i=1; i<100; i++){
            Debug.Log(i);
            if (Input.GetKey(KeyCode.Q)){
                launched = 1;
                if (i<=25)
                rb.AddForce(new Vector2 (0f, i * multiplier));
                else if (i>25 && i <=75)
                rb.AddForce(new Vector2 (0f, i * multiplier));
                else if (i>75)
                rb.AddForce(new Vector2 (0f, i * multiplier));
                break;}
            yield return new WaitForSeconds(spedometer);}
        if (launched == 0) // if adaugat deorece la primul click iese din for dar al doilea nu este breaked
        {
            for (i=100; i>0; i--){
            Debug.Log(i);
            if (Input.GetKey(KeyCode.Q)){
                launched = 1;
                if (i<=25)
                rb.AddForce(new Vector2 (0f, i * multiplier));
                else if (i>25 && i <=75)
                rb.AddForce(new Vector2 (0f, i * multiplier));
                else if (i>75)
                rb.AddForce(new Vector2 (0f, i * multiplier));
                break;}
            yield return new WaitForSeconds(spedometer);}
        }
        } while (launched == 0);
        
    }
}
