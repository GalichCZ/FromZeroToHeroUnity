using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]ScoreController sc;
    [SerializeField] BallBehaviour ball;
    private int leftScore;
    private int rightScore;
    
    void Start()
    {
        leftScore = 0;
        rightScore = 0;
        Invoke("StartGame", 3f);
    }

    private void StartGame()
    {
        ball.PullBall();
    }

    public void ScoreIncrease(string wall)
    {
        if(wall == "WallRight")
        {
            leftScore++;
            sc.SetLeftScore(leftScore);
        }
        else if (wall == "WallLeft")
        {
            rightScore++;
            sc.SetRightScore(rightScore);
        }
    }
}
