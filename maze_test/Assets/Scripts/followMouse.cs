using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class followMouse : MonoBehaviour
{
    public float distance = 1.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 new mousePosition = Input.mousePosition;
        Vector3 mousePosition = new Vector3();
        mousePosition = Input.mousePosition;
        mousePosition.z = distance;
        transform.position = Camera.main.ScreenToWorldPoint(mousePosition);

        //Testing different ways to print as it was not printing originally 
        //Debug.Log("TEST PRINT");
        //print("TEST PRINT");
        //Debug.LogWarning("TEST PRINT");

        //Prints out x, y, and z mouse coordinates to Unity console
        //Debug.LogWarning("values: " + transform.position);
        //Prints out x and y coordinates to unity console -- Error shouldnt print but my system was not working with Debug.Log
        //Debug.LogWarning("x val: " + transform.position.x + "y val: " + transform.position.y + "diff val: (submit difference in values here)" );

        // creating a linked list to store positions in to keep track of previous pos
        // this will help with filtering out coordinate data (repetitive)
        LinkedList<Vector3> position = new LinkedList<Vector3>();

        //fill array with elements of position
        //        position.AddLast(transform.position); // add new pos to end of list

        var currentPos = transform.position; // curr set to the position
        var lastPos = position.Last; // last set to the last element in list

        //if (currentPos != lastPos) // checks to make sure the current position isnt the same as the last, if it doesnt then print data
        {
            Debug.Log("X Value: " + transform.position.x + " Y Value: " + transform.position.y);
        }

    }
}
