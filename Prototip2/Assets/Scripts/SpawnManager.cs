using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 20;
    private float spawnPosZ = 20;
    private float StartDelay = 2;
    private float spawnInterval = 1.5f; // yumurtlama aralýðý.
    
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", StartDelay, spawnInterval);
    }

  
    void Update()
    {
     //Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
     // int animalIndex = Random.Range(0, animalPrefabs.Length);
     // Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
    void SpawnRandomAnimal()
    {
        Vector3 spawnpos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
         int animalIndex = Random.Range(0, animalPrefabs.Length);

         Instantiate(animalPrefabs[animalIndex], spawnpos, animalPrefabs[animalIndex].transform.rotation);
    }
}
