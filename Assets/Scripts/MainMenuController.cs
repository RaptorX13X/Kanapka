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
        Debug.Log("clicked");
    }

    public void HowToPlay()
    {
        menuCanvas.SetActive(false);
        howToPlayCanvas.SetActive(true);
        Debug.Log("clicked");
    }

    public void BackToMenu()
    {
        menuCanvas.SetActive(true);
        howToPlayCanvas.SetActive(false);
    }

    public void Test()
    {
        
        Debug.Log("clicked");
        
    }
}
