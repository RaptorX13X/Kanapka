using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoodIngridient : MonoBehaviour
{
    public Transform ingdirientAnchor;
    private FallingObject fallingObject;

    private void Awake()
    {
        fallingObject = GetComponent<FallingObject>();
    }

    public void AnchorYourself(Transform anchor)
    {
        fallingObject.isAttached = true;
        transform.position = anchor.position;
        transform.parent = anchor;
    }
    
}
