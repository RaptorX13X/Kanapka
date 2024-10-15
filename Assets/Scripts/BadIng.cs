using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadIng : MonoBehaviour
{
    private FallingObject fallingObject;

    private void Awake()
    {
        fallingObject = GetComponent<FallingObject>();
    }
}
