using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameLost ball;
    private bool isGameOver = true;
    void Update()
    {
        // If all four goals are solved then the game is over
        isGameOver = ball.GameOver;
    }

    void OnGUI()
    {
        if(isGameOver)
        {
            Rect rect = new Rect(Screen.width / 2 - 100, Screen.height / 2 - 50, 200, 75);
            GUI.Box (rect, "Game Over");
            Rect rect2 = new Rect(Screen.width / 2 - 30, Screen.height / 2 - 25, 60, 50);
            GUI.Label (rect2, "Try Again?");
        }
    }

}
