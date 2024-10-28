using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadIng : MonoBehaviour
{
    private FallingObject fallingObject;
    [SerializeField] private Vector3 fixTheFuckingRotation;

    private void Awake()
    {
        fallingObject = GetComponent<FallingObject>();
    }

    private void Start()
    {
        transform.rotation = Quaternion.Euler(fixTheFuckingRotation);
    }
}
