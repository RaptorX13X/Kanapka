using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishBun : MonoBehaviour
{
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
