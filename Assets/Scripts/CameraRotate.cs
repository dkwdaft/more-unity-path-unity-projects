using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotate : MonoBehaviour
{
    [SerializeField] private GameObject ball;
    [SerializeField] private float sensitivity = 5f;
    
    // Start is called before the first frame update
    void Start()
    {
        // Focus the camera on the Ball
        transform.LookAt(ball.transform);
    }

    // Update is called once per frame
    void Update()
    {
        //If the left mouse button held down, rotate the camera using mouse position
        if (Input.GetKey("mouse 0"))
        {
            float mouse = Input.GetAxis("Mouse Y");
            transform.Rotate(new Vector3(mouse * sensitivity * -1,0,0));
            float look = Input.GetAxis("Mouse X") * sensitivity;
            transform.RotateAround(ball.transform.position, Vector3.up, look);
        }
    }
}
