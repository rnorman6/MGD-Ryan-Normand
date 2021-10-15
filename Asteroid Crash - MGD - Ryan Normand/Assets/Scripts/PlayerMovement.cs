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


    public Rigidbody rb;


    private void Start()
    {
        rb = GetComponent<Rigidbody>();
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
                    //transform.Translate(Vector3.left * Time.deltaTime * speed);
                   
                    rb.AddForce(-speed, 0, 0, ForceMode.Impulse);
                    Debug.Log("Left");
                    stopTouch = true;
                }
                else if (Distance.x > swipeRange)
                {
                    //transform.Translate(Vector3.right * Time.deltaTime * speed);
                    
                    rb.AddForce(speed, 0, 0, ForceMode.Impulse);
                    Debug.Log("Right");
                    stopTouch = true;
                }
            }
        }

        if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            stopTouch = false;

            endTouchPosition = Input.GetTouch(0).position;

            Vector3 Distance = endTouchPosition - startTouchPosition;

            if(Mathf.Abs(Distance.x) < tapRange && Mathf.Abs(Distance.y) < tapRange)
            {
                Debug.Log("Tap");
            }
        }

       
    }

 
}
