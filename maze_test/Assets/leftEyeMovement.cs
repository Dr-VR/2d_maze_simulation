using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class leftEyeMovement : MonoBehaviour
{
    //create a varible in order to call rigidbody component
    public Rigidbody rb;
    //how much we move by default
    public float movementUnit = 100f;
    //variable to access the transform component of the left eye
    public Transform leftEye;

    
    string deviation;
    string rightEyeposition;
    string upperthreshold;
    string message;

    //to create the text file
    void CreateText(){
        //File path
        string path = Application.dataPath + "/Log.txt";

        //check that the file doesn't exist
        if(!File.Exists(path)){
            File.WriteAllText(path, "Eye_Info /n/n");
        }
        //place info into the file
        string info = "eye data; " + leftEye.position + "/n";
        File.AppendAllText(path, info);


    }

    // Start is called before the first frame update
    void Start()
    {
        //turn off gravity for the left eye sphere
        rb.useGravity = false; 
        //create the text
        CreateText();
    }

    // Update is called once per frame 
    //use FixedUpdate for physics components like rigidbody
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

        if(deviation>upperthreshold){
            message = "The eyes show sign of exotropia";
        }
        if(deviation<lowerthreshold){
            message = "The eyes show sign of esotropia";
        }
        else{
            message = "The eyes do not show abnormal signs";
        }


    }
}
