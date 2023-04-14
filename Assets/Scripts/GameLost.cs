using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLost : MonoBehaviour
{
    public bool GameOver = false;
    private void OnTriggerEnter(Collider collider)
    {
        GameObject collidedWith = collider.gameObject;
        if (collidedWith.tag == gameObject.tag)
        {
            GameOver = true;
            GetComponent<Light>().enabled = false;
            Destroy(collidedWith);
        }
        
    }
}
