using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreController : MonoBehaviour
{
    // Start is called before the first frame update
    private TextMeshProUGUI leftScoreText;
    private TextMeshProUGUI rightScoreText;

    void Start()
    {
        leftScoreText = transform.Find("ScoreLeft").GetComponent<TextMeshProUGUI>();
        rightScoreText = transform.Find("ScoreRight").GetComponent<TextMeshProUGUI>();
    }

    public void SetLeftScore(int score)
    {
        leftScoreText.text = score.ToString();
    }

    public void SetRightScore(int score)
    {
        rightScoreText.text = score.ToString();
    }

    
}
