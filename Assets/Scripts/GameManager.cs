using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    bool GameOver = false;
    int ballcount = 2;
    bool GameWin = false;
    int brickcount = 31;
    public GameObject textWin;
    public GameObject textLose;

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
                textLose.SetActive(true);
            }
        }

        if (GameWin == false)
        {
            if (brickcount == 0)
            {
                GameWin = true;
                textWin.SetActive(true);
            }
        }
    }
}
