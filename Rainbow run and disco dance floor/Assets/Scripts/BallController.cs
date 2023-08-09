using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] private Transform cameraTransform;

    [SerializeField] private string rightKey;

    [SerializeField] private string leftKey;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.transform.forward = cameraTransform.forward;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Calculates cameraTransform.forward without the y value so the ball doesn't move up and down on the Y axis
        Vector3 forward = new Vector3(cameraTransform.forward.x, 0, cameraTransform.forward.z).normalized;
        Vector3 right = Quaternion.AngleAxis(90, Vector3.up) * forward;
        Vector3 left = -right;

        if (Input.GetKey(rightKey))
        {
            rb.AddForce(right * 5f);
        }

        if (Input.GetKey(leftKey))
        {
            rb.AddForce(left * 5f);
        }
    }
}
