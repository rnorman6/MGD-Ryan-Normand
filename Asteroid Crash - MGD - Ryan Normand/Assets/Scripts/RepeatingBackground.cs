using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBackground : MonoBehaviour
{
    public float speed = -0.02f;
    private Renderer r;

    // Start is called before the first frame update
    void Start()
    {
        r = GetComponent<Renderer>(); //r is a reference to the renderer 
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 offset = new Vector3(0, Time.time * speed);
        r.material.mainTextureOffset = offset;   //offset material of object
    }
}
