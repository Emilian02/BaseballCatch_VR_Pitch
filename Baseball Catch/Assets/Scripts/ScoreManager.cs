using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    public int score = 0;

    public void UpdateScoreText()
    {
        scoreText.text = "Score: " + score;
    }
}
