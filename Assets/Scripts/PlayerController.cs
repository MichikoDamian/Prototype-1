using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   private float speed = 20.0f;
   private float turnSpeed = 45.0f;
   private float horizontalIntput;
   private float forwardInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalIntput = Input.GetAxis( "Horizontal" );
        forwardInput = Input.GetAxis( "Vertical" );
        // MOves the car forawrd based on vertical input
        // Move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput );
        // Rotates car based on horizontal input
        transform.Rotate(Vector3.up, turnSpeed * horizontalIntput * Time.deltaTime);
    }
}
