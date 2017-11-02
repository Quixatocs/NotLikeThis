using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Class to spawn a particular battery type of specific charge rate.
/// </summary>
public class BatterySpawner : MonoBehaviour {

    public List<GameObject> batteries;
    public float despawnTime = 30f;

    

    /// <summary>
    /// Spawns a battery with a random charge amount.
    /// </summary>
    public void SpawnBattery() {
        int RNGsus = Mathf.FloorToInt(Random.value * batteries.Count);
        GameObject obj = Instantiate(batteries[RNGsus], transform.position, Quaternion.identity);
        Destroy(obj, despawnTime);
    }


}
