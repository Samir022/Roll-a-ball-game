using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingballs : MonoBehaviour
{
    public float speed = 5f;

    private bool moveRight = true;


    // Update is called once per frame
    void Update()
    {
        if (moveRight)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }

        if (transform.position.x >= 9f)
        {
            moveRight = false;
        }
        else if (transform.position.x <= -9f)
        {
            moveRight = true;
        }
    }
}
