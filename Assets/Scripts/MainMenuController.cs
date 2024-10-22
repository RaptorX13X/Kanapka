using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    [SerializeField] private GameObject menuCanvas;
    [SerializeField] private GameObject howToPlayCanvas;
    [SerializeField] private int gameSceneIndex;

    private void Start()
    {
        menuCanvas.SetActive(true);
        howToPlayCanvas.SetActive(false);
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(gameSceneIndex);
    }

    public void HowToPlay()
    {
        menuCanvas.SetActive(false);
        howToPlayCanvas.SetActive(true);
    }

    public void BackToMenu()
    {
        menuCanvas.SetActive(true);
        howToPlayCanvas.SetActive(false);
    }
}