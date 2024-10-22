using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreController : MonoBehaviour
{
    private int score = 0;
    [SerializeField] private int scorePerObject = 5;
    [SerializeField] private TextMeshProUGUI scoreText;

    private void Start()
    {
        score = 0;
    }

    public void AddScore()
    {
        score += scorePerObject;
        scoreText.text = score.ToString();
    }
}
