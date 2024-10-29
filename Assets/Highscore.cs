using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Highscore : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI text;

    private void Start()
    {
        text.text = "High Score: " + PlayerPrefs.GetInt("Score");
    }
}
