using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timerText;
    public GameObject youloseText;
    public GameObject youwinText;

    private float startTime = 40f;
    public float currentTime = 0f;
    public float speed = 0.3f;

    public static float size;

    void Start()
    {

        currentTime = startTime;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        timerText.text = currentTime.ToString("0");

        if(currentTime <= 0)
        {
            currentTime = 0;
            timerText.color = Color.red;
        }

        if (currentTime <= 10)
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }


    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Time.timeScale = 0;
            Debug.Log("Game Over!");

            if (size >= 10)
            {
                youwinText.SetActive(true);
            }

            if (size < 10)
            {
                youloseText.SetActive(true);
            }            
        }
    }
}
