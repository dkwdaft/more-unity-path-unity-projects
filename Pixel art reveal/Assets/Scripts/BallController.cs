using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    private Rigidbody rb;
    public Transform cameraTransform;
    public string upKey;
    public string leftKey;
    public string downKey;
    public string rightKey;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.transform.forward = cameraTransform.forward;
    }

    // FixedUpdate is called once per frame
    void FixedUpdate()
    {
        Vector3 forward = new Vector3(cameraTransform.forward.x, 0, cameraTransform.forward.z).normalized;
        Vector3 right = Quaternion.AngleAxis(90, Vector3.up) * forward;
        Vector3 left = -right;
        Vector3 backward = -forward;

        if (Input.GetKey(rightKey) )
        {
            rb.AddForce(right * 5f);
        }

        if (Input.GetKey(leftKey))
        {
            rb.AddForce(left * 5f);
        }

        if (Input.GetKey(upKey))
        {
            rb.AddForce(forward * 10f);
        }

        if (Input.GetKey(downKey))
        {
            rb.AddForce(backward * 2f);
        }

        if (this.transform.position.y < -10)
        {
            rb.linearVelocity = Vector3.zero;
            this.transform.position = new Vector3(0, 1, 0);
            rb.linearVelocity = Vector3.zero;
        }
    }
}