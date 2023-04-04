using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]ScoreController sc;
    [SerializeField] BallBehaviour ball;
    public GameObject Menu;
    private int leftScore;
    private int rightScore;
    bool isMenu = false;

    void Start()
    {
        leftScore = 0;
        rightScore = 0;
        Invoke("StartGame", 3f);
        Menu.SetActive(false);
    }

    private void StartGame()
    {
        ball.PullBall();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            MenuHandler();
        }
    }

    public void MenuHandler()
    {
        isMenu = !isMenu;
        Menu.SetActive(isMenu);
        ball.RememberDirection(isMenu);
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
