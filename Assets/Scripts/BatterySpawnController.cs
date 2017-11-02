using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Class to choose which battery spawner to spawn a battery at.
/// Also decides on the time interval between each spawning.
/// </summary>
public class BatterySpawnController : MonoBehaviour {

    public List<GameObject> dispensers;
    public float spawnDelay;
    public float spawnInterval;

	void Start () {
        InvokeRepeating("ChooseDispenserAndSpawn", spawnDelay, spawnInterval);
    }


    private void ChooseDispenserAndSpawn()
    {
        int RNGsus = Mathf.FloorToInt(Random.value * dispensers.Count);
        dispensers[RNGsus].GetComponent<BatterySpawner>().SpawnBattery();
    }


}
