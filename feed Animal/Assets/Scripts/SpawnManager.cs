using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float xSpawn = 10;
    private float zSpawn = 20;
    // Start is called before the first frame update
    void Start()
    {
        //Invoke the method to so the animals apear each 1.5s after 2s of start of game.
        InvokeRepeating("SpawnRandomAnimal", 2.0f, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomAnimal()
    {
        //Animals positions
        Vector3 spawnPos = new Vector3(UnityEngine.Random.Range(-xSpawn, xSpawn), 0, zSpawn);

        int animalIndex = UnityEngine.Random.Range(0, animalPrefabs.Length);
        //get a copy of each animals
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}
