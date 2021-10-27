using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] spawnPrefabs;
    public Vector3[] spawnLocations;

    private float startDelay = 2f;
    private float spawnInterval = 1.6f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomObstacle", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomObstacle()
    {
        int spawnIndex = Random.Range(0, spawnPrefabs.Length);
        int locationIndex = Random.Range(0, spawnLocations.Length);
        Instantiate(spawnPrefabs[spawnIndex], spawnLocations[locationIndex], spawnPrefabs[spawnIndex].transform.rotation);
    }

}
