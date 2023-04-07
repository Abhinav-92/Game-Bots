using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject[] asteroidPrefabs;
    private float spawnRangeX = 2;
    private float spawnPosY = 4.5f;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;

    void Start()
    {
        InvokeRepeating("SpawnRandomAsteroid", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomAsteroid(){

            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), spawnPosY, 0);
            int animalIndex = Random.Range(0, asteroidPrefabs.Length);

            Instantiate(asteroidPrefabs[animalIndex], spawnPos, asteroidPrefabs[animalIndex].transform.rotation);
    }
}
