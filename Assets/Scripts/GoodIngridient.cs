using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoodIngridient : MonoBehaviour
{
    public Transform ingdirientAnchor;
    private FallingObject fallingObject;
    public bool anchored = false;

    private void Awake()
    {
        fallingObject = GetComponent<FallingObject>();
    }

    public void AnchorYourself(Transform anchor)
    {
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
