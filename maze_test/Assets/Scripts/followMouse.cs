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

        Debug.Log("Coordinates : " + mousePosition);
        Debug.Log("Coordinates : " + transform.position);

    }
}
