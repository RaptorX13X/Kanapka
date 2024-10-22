using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseController : MonoBehaviour
{
    [SerializeField] private GameObject pauseMenu;
    [SerializeField] private GameObject gameUI;
    [SerializeField] private GameObject gameOver;
    [SerializeField] private TextMeshProUGUI gameOverScore;
    [SerializeField] private ScoreController scoreController;

    private void Start()
    {
        gameUI.SetActive(true);
        pauseMenu.SetActive(false);
        gameOver.SetActive(false);
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
        gameUI.SetActive(false);
        pauseMenu.SetActive(true);
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
        gameUI.SetActive(true);
        pauseMenu.SetActive(false);
    }

    public void BackToMenu()
    {
        //SceneManager.LoadScene()
    }

    public void GameOver()
    {
        gameOver.SetActive(true);
        gameOverScore.text = scoreController.score.ToString();
    }
}
