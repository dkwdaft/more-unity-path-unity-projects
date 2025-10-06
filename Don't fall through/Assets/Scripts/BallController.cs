using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] private Transform cameraTransform;
    [SerializeField] private string forwardKey;
    [SerializeField] private string leftKey;
    [SerializeField] private string backwardKey;
    [SerializeField] private string rightKey;
    Rigidbody rb;
    Vector3 spawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.transform.forward = cameraTransform.forward;
        spawnPoint = transform.position;
    }
    
    // Update is called once per frame
    private void FixedUpdate()
    {
        Vector3 forward = new Vector3(cameraTransform.forward.x, 0, cameraTransform.forward.z).normalized;
        Vector3 right = Quaternion.AngleAxis(90, Vector3.up) * forward;
        Vector3 left = -right;
        Vector3 backward = -forward;

        if (Input.GetKey(rightKey))
        {
            rb.AddForce(right * 5f);
        }
        
        if (Input.GetKey(leftKey))
        {
            rb.AddForce(left * 5f);
        }
        
        if (Input.GetKey(forwardKey))
        {
            rb.AddForce(forward * 10f);
        }
        
        if (Input.GetKey(backwardKey))
        {
            rb.AddForce(backward * 2f);
        }

        if (this.transform.position.y < -10)
        {
            rb.linearVelocity = Vector3.zero;
            transform.position = spawnPoint;
        }
    }
}
