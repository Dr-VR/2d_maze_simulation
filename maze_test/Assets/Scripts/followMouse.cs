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
        Debug.LogError("values: " + transform.position);
        //Prints out x and y coordinates to unity console
        Debug.LogError("x val: " + transform.position.x + "y val: " + transform.position.y);



    }
}
