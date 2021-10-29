using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerChanger : MonoBehaviour
{
    public GameObject phaseone;

    public GameObject phasetwo;

    public GameObject phasethree;

    public static float size = 0f;

    public float value = 0f;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        value = size;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Consumable")
        {

            size += 1;
            Debug.Log("consumable!");
        }

        if (other.gameObject.tag == "Destructable")
        {

            size -= 3;
            Debug.Log("destructable!");
        }

        if (size < 10)
        {
            phaseone.SetActive(true);
            phasetwo.SetActive(false);
            phasethree.SetActive(false);
        }

        if (size >= 10 && size < 20)
        {
            phaseone.SetActive(false);
            phasetwo.SetActive(true);
            phasethree.SetActive(false);
        }

        if (size >= 20)
        {
            phaseone.SetActive(false);
            phasetwo.SetActive(false);
            phasethree.SetActive(true);
        }

        Debug.Log(size);
    }
}
