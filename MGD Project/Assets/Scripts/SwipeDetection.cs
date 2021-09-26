using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeDetection : MonoBehaviour
{

    private Vector3 startPos;
    public int pixelDistToDetect = 20;
    private bool fingerDown;
    
    void Update ()
    {

        if(fingerDown && Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Ended)
        {
            fingerDown = false;
        }

        if(fingerDown == false && Input.touchCount > 0  && Input.touches[0].phase == TouchPhase.Began)
        {
            startPos = Input.touches[0].position;
            fingerDown = true;
        }

        if (fingerDown)
        {
            if (Input.touches[0].position.y >= startPos.y + pixelDistToDetect)
            {
                fingerDown = false;
                Debug.Log("Swipe up");
            }
        }

        if(fingerDown && Input.GetMouseButtonUp(0))
        {
            fingerDown = false;
        }
    }
}
