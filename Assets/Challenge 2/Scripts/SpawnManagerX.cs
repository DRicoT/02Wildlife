using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;
    private float spawnInterval = 4.0f;
    
    private float counterTime;
    private float nextWaitTime = 5f;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomBall", startDelay, spawnInterval);
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);
        int spawnPrefab = Random.Range(0, 2);
        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[spawnPrefab], spawnPos, ballPrefabs[0].transform.rotation);
    }

    private void Update()
    {
        counterTime += Time.deltaTime;
        if (counterTime >= nextWaitTime )
        {
            Invoke("SpawnRandomBall",0f);
            counterTime = 0f;
            nextWaitTime = Random.Range(2, 5);
            Debug.LogFormat("Se ha tardado {0} en spawnear la bola", nextWaitTime);
        }
    }
}
