using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    bool GameOver = false;
    int ballcount = 5;

    bool GameWin = false;
    int brickcount = 31;
    public void BallRemove()
    {
        ballcount--;
    }

    public void BrickRemove()
    {
        brickcount--;
    }
  
    void Update()
    {
        if (GameOver == false)
        {
            if (ballcount == 0)
            {
                GameOver = true;
                Debug.Log("Game Over :(");
            }
        }

        if (GameWin == false)
        {
            if (brickcount == 0)
            {
                GameWin = true;
                Debug.Log("Level Complete :)");
            }
        }
    }
}
