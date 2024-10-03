using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            Vector3 touchPosition = GetTouchWordlPosition();

            touchPosition.z = transform.position.z;
            touchPosition.y = transform.position.y;
            
            switch (touch.phase)
            {
                case TouchPhase.Began:
                    //transform.position = touchPosition;
                    break;

                case TouchPhase.Moved:
                case TouchPhase.Stationary:
                    transform.position = Vector3.Lerp(transform.position, touchPosition, Time.deltaTime * speed);
                    break;

            }
        }
    }

    Vector3 GetTouchWordlPosition()
    {
        Vector3 touchPosScreen = Input.GetTouch(0).position;
        
        Vector3 touchPosWorld = Camera.main.ScreenToWorldPoint
            (new Vector3(touchPosScreen.x, touchPosScreen.y, Mathf.Abs(transform.position.z - Camera.main.transform.position.z)));

        return touchPosWorld;
    }
}
