using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoundController : MonoBehaviour
{
    public float bonusRoundTime = 0;

    public void AddRoundTime()
    {
        bonusRoundTime += 1;
    }
}
