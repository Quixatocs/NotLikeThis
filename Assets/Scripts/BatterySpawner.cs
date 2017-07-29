using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatterySpawner : MonoBehaviour {

    public List<GameObject> batteries;
    public float despawnTime = 30f;

    

    public void SpawnBattery() {
        int RNGsus = Mathf.FloorToInt(Random.value * batteries.Count);
        GameObject obj = Instantiate(batteries[RNGsus], transform.position, Quaternion.identity);
        Destroy(obj, despawnTime);
    }


}
