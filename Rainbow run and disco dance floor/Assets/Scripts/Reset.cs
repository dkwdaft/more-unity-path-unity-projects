using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour
{
    private Vector3 spawnPoint;
    private Rigidbody rb;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        spawnPoint = transform.position;
    }

    public void resetBall()
    {
        rb.velocity = Vector3.zero;
        transform.position = spawnPoint;
    }
}
