using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]ScoreController sc;
    private int leftScore;
    private int rightScore;
    public bool Started;
    
    void Start()
    {
        Started = false;
        leftScore = 0;
        rightScore = 0;
        Invoke("StartGame", 3f);
    }

    private void StartGame()
    {
        Started = true;
        Debug.Log("Started");
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
