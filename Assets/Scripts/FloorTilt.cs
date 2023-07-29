using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorTilt : MonoBehaviour
{
    [SerializeField] private float maxTilt;
    [SerializeField] private float turnSpeed;

    [SerializeField] private string forwardKey;
    [SerializeField] private string backwardKey;
    [SerializeField] private string leftKey;
    [SerializeField] private string rightKey;

    // Update is called once per frame
    void Update()
    {
        float targetXRotation = 0;

        if (Input.GetKey(forwardKey))
        {
            targetXRotation += maxTilt;
        }

        if (Input.GetKey(backwardKey))
        {
            targetXRotation += 360 - maxTilt;
        }

        float targetZRotation = 0;
        
        if (Input.GetKey(rightKey))
        {
            targetZRotation += 360 - maxTilt;
        }

        if (Input.GetKey(leftKey))
        {
            targetZRotation += maxTilt;
        }

        Quaternion targetRotation = Quaternion.Euler(targetXRotation, 0, targetZRotation);

        transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, turnSpeed * Time.deltaTime);

    }
}
