using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinMotion : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(0f, 200f * Time.deltaTime, 0f, Space.Self);
    }
}
