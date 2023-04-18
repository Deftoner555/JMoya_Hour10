using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperMovement : MonoBehaviour
{
    private float BumperSpeed = 2f;
    public float minX = -16.6f, maxX = 19f, minY = 1, maxY = 1;
    private void Update()
    {
        float mxVal = Input.GetAxis("Mouse X");
        transform.Translate(mxVal * BumperSpeed, 0, 0);

        //player boundaries for X-axis
        if (transform.position.x < minX)
        {
            transform.position = new Vector3(minX, transform.position.y, 0);
        }
        else if (transform.position.x > maxX)
        {
            transform.position = new Vector3(maxX, transform.position.y, 0);
        }

        //player boundaries for Y-axis
        if (transform.position.y < minY)
        {
            transform.position = new Vector3(transform.position.x, minY, 0);
        }
        else if (transform.position.y > maxY)
        {
            transform.position = new Vector3(transform.position.x, maxY, 0);
        }
    }
}
