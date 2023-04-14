using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    void Start()
    {
        
    }

    bool GameOver = false;

    int count = 5;
    public void BallRemove()
    {
        count--;
    }
  
    void Update()
    {
        if (GameOver == false)
        {
            if (count == 0)
            {
                GameOver = true;
                Debug.Log("Game Over :(");
            }
        }
    }
}
