using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingObject : MonoBehaviour
{
    [SerializeField] private float fallSpeed = 0.5f;
    public bool isAttached = false;
    private void Update()
    {
        if (isAttached) return;
        transform.position -= new Vector3(0, fallSpeed, 0) * Time.deltaTime;
    }
}
