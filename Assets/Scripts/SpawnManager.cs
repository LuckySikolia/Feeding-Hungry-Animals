using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //initialize the animal prefabs game object as an array
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 20;
    private float spawnPositionZ = 20;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //initialize animal index for randomness
        int animalIndex = Random.Range(0, animalPrefabs.Length);

        //ensure the animals spawn at a random location
        Vector3 spawnPosition = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPositionZ);

        //method to spawn an animal if s is pressed
        if (Input.GetKeyDown(KeyCode.S))
        {
            Instantiate(animalPrefabs[animalIndex],spawnPosition , animalPrefabs[animalIndex].transform.rotation);
        }


    }



}
