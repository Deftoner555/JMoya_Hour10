using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperMovement : MonoBehaviour
{
    private float BumperSpeed = 2f; 
    private void Update()
    {
        float mxVal = Input.GetAxis("Mouse X");
        transform.Translate(mxVal * BumperSpeed, 0, 0);
    }

    public float minX = -16.6f, maxX = 16.7f;
    void PlayerMovement()
    {
        //Player boundaries for X-axis
        if(transform.position.x < minX)
        {
            transform.position = new Vector3(minX, transform.position.y, 0);
        }
        else if (transform.position.x > maxX)
        {
            transform.position = new Vector3(maxX, transform.position.y, 0);
        }
    }
}
