using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{

    public GameObject[] asteroidPrefabs;
    private float spawnRangeX = 2;
    private float spawnPosY = 4.5f;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;

    void Start()
    {
        InvokeRepeating("SpawnRandomAsteroid", startDelay, spawnInterval);
    }
    
    void SpawnRandomAsteroid(){

            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), spawnPosY, -1);
            int enemyIndex = Random.Range(0, asteroidPrefabs.Length);

            Instantiate(asteroidPrefabs[enemyIndex], spawnPos, asteroidPrefabs[enemyIndex].transform.rotation);
    }
}
