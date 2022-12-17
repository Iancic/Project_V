using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet : MonoBehaviour
{
    public GameObject planet;

    public float gravityForce;

    public float gravityDistance;
    
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float dist = Vector3.Distance(gameObject.transform.position, planet.transform.position);

        Vector3 v = planet.transform.position - transform.position;

        rb.AddForce(v.normalized * (1.0f - dist / gravityDistance) * gravityForce);

    }
}
