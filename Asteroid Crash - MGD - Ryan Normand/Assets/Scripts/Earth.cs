using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Earth : MonoBehaviour
{
    public float currentTime = 0f;

    public float speed = 3f;

    public GameObject Timer;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);
        if (Timer.GetComponent<Timer>().currentTime == 10)
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
            Debug.Log("Upsy!");
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Game Over!");
        }
    }
}
