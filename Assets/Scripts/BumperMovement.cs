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
}
