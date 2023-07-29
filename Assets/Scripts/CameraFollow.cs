using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
   [SerializeField] private GameObject ball;
    private Vector3 prevBallPos;

    void Start()
    {
        // Calculate where the camera is in relation to the player (ball)
        transform.LookAt(ball.transform);
        prevBallPos = ball.transform.position;
    }

    void Update()
    {
        // Moves the camera by the same amount the ball has moved
        transform.Translate(ball.transform.position - prevBallPos, Space.World);
        prevBallPos = ball.transform.position;
    }
}