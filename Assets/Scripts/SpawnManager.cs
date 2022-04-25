﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private float startDelay = 2;
    private float repeatRate = 2;
    private PlayerController playerControllerScript;
    private Vector3 spawnPos = new Vector3(25, 0, 00);
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }
    void SpawnObstacle()
    {
        if (playerControllerScript.gameOver == false) ;
        { 
            Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation); 
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
