using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatterySpawner : MonoBehaviour {

	public GameObject batteryType1;
    public GameObject batteryType2;
    public GameObject batteryType3;
    

    public void SpawnBattery() {
        int RNGsus = Mathf.FloorToInt(Random.value * 3);

        switch (RNGsus)
        {
            case 0:
                Instantiate(batteryType1, transform.position, Quaternion.identity);
                break;
            case 1:
                Instantiate(batteryType2, transform.position, Quaternion.identity);
                break;
            case 2:
                Instantiate(batteryType3, transform.position, Quaternion.identity);
                break;
            default:
                Debug.Log("No switch case for value " + RNGsus);
                break;
        }
    }


}
