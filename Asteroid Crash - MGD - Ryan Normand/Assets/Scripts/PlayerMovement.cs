using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Vector3 startTouchPosition;
    private Vector3 currentPosition;
    private Vector3 endTouchPosition;
    private bool stopTouch = false;


    public float swipeRange;
    public float tapRange;
    public float speed = 3f;

    public Transform middlelane;
    public Transform rightlane;
    public Transform leftlane;

    private void Start()
    {
       
    }


    // Update is called once per frame
    void Update()
    {
        Swipe();

    }

    public void Swipe()
    {
        //input controls

        if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            startTouchPosition = Input.GetTouch(0).position;
        }

        if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            currentPosition = Input.GetTouch(0).position;
            Vector3 Distance = currentPosition - startTouchPosition;

            if (!stopTouch)
            {
                if(Distance.x < -swipeRange)
                {

                    if (transform.position.x == -2)
                    {
                        //transform.position = Vector3.Lerp(transform.position, leftlane.position, Time.deltaTime);
                        transform.position = new Vector3(-2, 0, 0);
                       
                    } 


                    if (transform.position.x == 0)
                    {
                        //transform.position = Vector3.Lerp(transform.position, leftlane.position, Time.deltaTime);
                        transform.position = new Vector3(-2, 0, 0);
                        

                    }

                    if (transform.position.x == 2)
                    {
                        //transform.position = Vector3.Lerp(transform.position, middlelane.position, Time.deltaTime);
                        transform.position = new Vector3(0, 0, 0);
                        
                    }
                    stopTouch = true;
                    Debug.Log("Left");
                }
                else if (Distance.x > swipeRange)
                {
                    if(transform.position.x == 2)
                    {
                        //transform.position = Vector3.Lerp(transform.position, rightlane.position, Time.deltaTime);
                        transform.position = new Vector3(2, 0, 0);
                        
                    }

                    if (transform.position.x == 0)
                    {
                        //transform.position = Vector3.Lerp(transform.position, rightlane.position, Time.deltaTime);
                        transform.position = new Vector3(2, 0, 0);
                       
                    }

                    if (transform.position.x == -2)
                    {
                        //transform.position = Vector3.Lerp(transform.position, middlelane.position, Time.deltaTime);
                        transform.position = new Vector3(0, 0, 0);
                        
                    }
                    stopTouch = true;
                    Debug.Log("Right");
                }
            } 


        }

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            stopTouch = false;

            endTouchPosition = Input.GetTouch(0).position;

            Vector3 Distance = endTouchPosition - startTouchPosition;

            if (Mathf.Abs(Distance.x) < tapRange && Mathf.Abs(Distance.y) < tapRange)
            {
                Debug.Log("Tap");
            }
        }


    }


}
