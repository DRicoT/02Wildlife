using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemies;
    public int animalIndex;

    private float spawnRangeX = 20.0f;
    private float spawnPosZ;

    private void Start()
    {
        spawnPosZ = this.transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        
       
        /*if (animalIndex >= 0 && animalIndex < enemies.Length)
        {*/
            if (Input.GetKeyDown(KeyCode.R))
            {
                //Generar la posición donde aparecerán los enemigos
                Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX,spawnRangeX), 0, spawnPosZ);
                animalIndex = Random.Range(0, enemies.Length);
               
                Instantiate(enemies[animalIndex],spawnPos,
                    enemies[animalIndex].transform.rotation);
            }
            //El animal existe
        /*}
        else
        {
            Debug.LogError("El número de instanciamiento NO es correcto");
        }*/
    }
}
