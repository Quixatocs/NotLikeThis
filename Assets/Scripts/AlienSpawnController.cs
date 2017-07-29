using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienSpawnController : MonoBehaviour {

    public List<GameObject> aliens;


    public void SpawnAlien()
    {
        int RNGsus = Mathf.FloorToInt(Random.value * aliens.Count);
        Instantiate(aliens[RNGsus], transform.position, Quaternion.identity);
    }

}
