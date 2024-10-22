using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private int health = 3;
    [SerializeField] private List<GameObject> healthIndicators = new List<GameObject>();
    [SerializeField] PauseController pauseController;


    public void Damage()
    {
        health--;
        healthIndicators[health].SetActive(false);
        if (health == 0)
        {
            Die();
        }
    }

    private void Die()
    {
        Time.timeScale = 0;
        pauseController.GameOver();
    }
}
