using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingball2 : MonoBehaviour
{
    public float speed = 4f; // The speed at which the ball moves
    public float distance = 2f; // The distance the ball should travel before reversing direction

    private float startPosition; // The initial position of the ball
    private bool goingForward = true; // Whether the ball is currently moving forward or backward

    private void Start()
    {
        startPosition = transform.position.z; // Record the initial position of the ball
    }

    private void Update()
    {
        float direction = goingForward ? 1 : -1; // The direction in which the ball is currently moving

        transform.Translate(0f, 0f, direction * speed * Time.deltaTime); // Move the ball in the z-axis

        // If the ball has traveled the desired distance, reverse direction
        if (Mathf.Abs(transform.position.z - startPosition) > distance / 2)
        {
            goingForward = !goingForward;
        }
    }
}
