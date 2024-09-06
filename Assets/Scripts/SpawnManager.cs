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
    private float spawnDelay = 2;
    private float spawnInterval = 1.5f;
    
    // Start is called before the first frame update
    void Start()
    {
        //spawn animal using timer
        InvokeRepeating("SpawnRandomAnimal", spawnDelay, spawnInterval);
        
    }

    // Update is called once per frame
    void Update()
    {


        //method to spawn an animal if s is pressed
        //if (Input.GetKeyDown(KeyCode.S))
        //{
        //    //call the spawn random animal
        //    spawnRandomAnimal();
        //}

        
    }


    void SpawnRandomAnimal()
    {
          //initialize animal index for randomness
            int animalIndex = Random.Range(0, animalPrefabs.Length);

            //ensure the animals spawn at a random location
            Vector3 spawnPosition = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPositionZ);

            Instantiate(animalPrefabs[animalIndex], spawnPosition, animalPrefabs[animalIndex].transform.rotation);
        }

}
