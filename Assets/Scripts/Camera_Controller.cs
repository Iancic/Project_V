
using UnityEngine;

public class Camera_Controller : MonoBehaviour
{
    public Transform focus;
    public float smoothness = 0.4f;
    public Vector3 offset;

    void FixedUpdate()
    {
      if(focus != null) 
      //verifica daca mai exista obiectul care trebuie urmarit
      {
      Vector3 desiredposition = focus.position + offset;  
      Vector3 smoothedposition = Vector3.Lerp(transform.position, desiredposition, smoothness);
      //big smoothness number (more locked) small smothness number (loose)
      transform.position = smoothedposition;
      }
    }


}
