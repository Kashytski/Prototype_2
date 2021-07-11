using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalsPrefabs;
    private float spawnRangeX = 25;
    private float spawnRangeZ = 20;
    private float startDelay = 2;
    private float timeInterval = 1;
    // Start is called before the first frame update
    void Start()
    {
        //use SpawnRandomAnimal sometimes
        InvokeRepeating("SpawnRandomAnimal", startDelay, timeInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomAnimal()
    {
        //get random animal and random place to spawn
        int animalIndex = Random.Range(0, animalsPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnRangeZ);

        Instantiate(animalsPrefabs[animalIndex], spawnPos, animalsPrefabs[animalIndex].transform.rotation);
    }
}
