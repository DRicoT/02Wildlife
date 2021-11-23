using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemies;
    private int animalIndex;

    private float spawnRangeX = 20f;
    private float spawnPosZ;
    
    [SerializeField, Range(2,5)]
    private float startDelay = 2f;
    [SerializeField, Range(1,5)]
    private float spawnInterval = 1.5f;
    
    private void Start()
    {
        spawnPosZ = this.transform.position.z;
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        

        /*if (animalIndex >= 0 && animalIndex < enemies.Length)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                SpawnRandomAnimal();
            }
            //El animal existe
            }
            else
            {
                Debug.LogError("El número de instanciamiento NO es correcto");
            }*/
    }

    private void SpawnRandomAnimal()
    {
        //Generar la posición donde aparecerán los enemigos
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX,spawnRangeX), 0, spawnPosZ);
        animalIndex = Random.Range(0, enemies.Length);
               
        Instantiate(enemies[animalIndex],spawnPos,
            enemies[animalIndex].transform.rotation);
    }
}
