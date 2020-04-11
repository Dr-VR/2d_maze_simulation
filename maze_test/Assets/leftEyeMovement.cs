using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leftEyeMovement : MonoBehaviour
{
    //create a varible in order to call rigidbody component
    public Rigidbody rb;
    //how much we move by default
    public float movementUnit = 100f;
    //variable to access the transform component of the left eye
    public Transform leftEye;



    // Start is called before the first frame update
    void Start()
    {
        //turn off gravity for the left eye sphere
        rb.useGravity = false; 
    }



    // Update is called once per frame, use FixedUpdate for physics components like rigidbody
    void FixedUpdate()
    {
        //x-axis
        if(Input.GetKey("a")){
            rb.AddForce(-movementUnit * Time.deltaTime,0,0);
        }
        if(Input.GetKey("d")){
            rb.AddForce(movementUnit * Time.deltaTime,0,0);
        }
        //y-axis
        if(Input.GetKey("w")){
            rb.AddForce(0,movementUnit * Time.deltaTime,0);
        }
        if(Input.GetKey("s")){
            rb.AddForce(0,-movementUnit * Time.deltaTime,0);
        }

        
        Debug.Log(leftEye.position);

    }
}
