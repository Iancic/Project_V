using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    private Rigidbody2D rb;
    public float thrustlow, thrustmid, thrusthigh, spedometer;
    private int i, launched = 0;
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
                rb.AddForce(new Vector2 (0f, thrustlow));
                else if (i>25 && i <=75)
                rb.AddForce(new Vector2 (0f, thrustmid));
                else if (i>75)
                rb.AddForce(new Vector2 (0f, thrusthigh));
                break;}
            yield return new WaitForSeconds(spedometer);}
        if (launched == 0) // if adaugat deorece la primul click iese din for dar al doilea nu este breaked
        {
            for (i=100; i>0; i--){
            Debug.Log(i);
            if (Input.GetKey(KeyCode.Q)){
                Debug.Log("MATA");
                launched = 1;
                if (i<=25)
                rb.AddForce(new Vector2 (0f, thrustlow));
                else if (i>25 && i <=75)
                rb.AddForce(new Vector2 (0f, thrustmid));
                else if (i>75)
                rb.AddForce(new Vector2 (0f, thrusthigh));
                break;}
            yield return new WaitForSeconds(spedometer);}
        }
        } while ( launched == 0);
        
    }
}
