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
    [SerializeField] private GameObject howToPlay;
    [SerializeField] private TextMeshProUGUI gameOverScore;
    [SerializeField] private ScoreController scoreController;
    [SerializeField] private int menuSceneIndex = 0;
    [SerializeField] private int gameSceneIndex = 1;
    

    private void Start()
    {
        Time.timeScale = 1;
        gameUI.SetActive(true);
        pauseMenu.SetActive(false);
        gameOver.SetActive(false);
        howToPlay.SetActive(false);
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
        SceneManager.LoadScene(menuSceneIndex);
    }

    public void Restart()
    {
        SceneManager.LoadScene(gameSceneIndex);
    }

    public void HowToPlay()
    {
        pauseMenu.SetActive(false);
        howToPlay.SetActive(true);
    }

    public void ExitHTP()
    {
        pauseMenu.SetActive(true);
        howToPlay.SetActive(false);
    }
    public void GameOver()
    {
        gameOver.SetActive(true);
        gameOverScore.text = scoreController.score.ToString();
    }
}
