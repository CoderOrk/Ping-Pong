using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreKeeper : MonoBehaviour
{
    int score = 0;

    [SerializeField] TextMeshProUGUI scoreText;

    void Start()
    {
        scoreText.text = score.ToString("000");
    }

   public void IncreaseScore()
    {
        score++;
        scoreText.text = score.ToString("000");
        Debug.Log("Score: " + score);
    }

    public void ResetScore()
    {
        score = 0;
    }
}
