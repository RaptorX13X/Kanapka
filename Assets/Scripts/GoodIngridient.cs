using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoodIngridient : MonoBehaviour
{
    public Transform ingdirientAnchor;
    private FallingObject fallingObject;
    public bool anchored = false;
    private MeshRenderer renderer;
    [SerializeField] private GameObject fakeFall;
    private void Awake()
    {
        fallingObject = GetComponent<FallingObject>();
        renderer = GetComponent<MeshRenderer>();
        renderer.enabled = false;
        fakeFall.SetActive(true);
    }

    public void AnchorYourself(Transform anchor)
    {
        renderer.enabled = true;
        fakeFall.SetActive(false);
        if (fallingObject.isAttached)
        {
            anchored = true;
            return;
        }
        fallingObject.isAttached = true;
        transform.position = anchor.position;
        transform.parent = anchor;
    }
    
}
