﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Class that chooses which spawn gameobject to spawn alien at. The spawners will be provided
/// in a list. Also controls a difficulty multiplier for increasing the amount of spawning as 
/// the game progresses.
/// </summary>
public class AlienSpawnChooser : MonoBehaviour {

    public List<GameObject> alienSpawners;
    public float initialSpawnDelay = 5f;
    public float spawnIntervalMinRange = 10f;
    public float spawnIntervalMaxRange = 15f;
    public float increaseSpawnRateTimer = 15f;
    private float timeDifficultyMultiplier = 1f;
    private float timeWhenRateIncreased = 0f;

    void Start()
    {
        timeWhenRateIncreased = Time.timeSinceLevelLoad;
        Invoke("ChooseSpawnerAndSpawnAlien", initialSpawnDelay);
    }



    private void ChooseSpawnerAndSpawnAlien()
    {
        if (Time.timeSinceLevelLoad - timeWhenRateIncreased > increaseSpawnRateTimer) {
            timeWhenRateIncreased = Time.timeSinceLevelLoad;
            timeDifficultyMultiplier *= 0.8f;
        }
        int RNGsus = Mathf.FloorToInt(Random.value * alienSpawners.Count);
        alienSpawners[RNGsus].GetComponent<AlienSpawnController>().SpawnAlien();
        float randoTime = Random.Range(spawnIntervalMinRange * timeDifficultyMultiplier, spawnIntervalMaxRange * timeDifficultyMultiplier);
        Invoke("ChooseSpawnerAndSpawnAlien", randoTime);
    }
}
