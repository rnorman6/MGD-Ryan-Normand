using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float speed = 5.0f;

    public float outofbounds = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime, Space.World);

        if (transform.position.y > outofbounds)
        {
            Destroy(gameObject);
        }
    }

   void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
