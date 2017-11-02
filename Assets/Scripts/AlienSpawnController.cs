using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Class to randomly choose between which aliens are to be spawned
/// </summary>
public class AlienSpawnController : MonoBehaviour {

    public List<GameObject> aliens;


    public void SpawnAlien()
    {
        int RNGsus = Mathf.FloorToInt(Random.value * aliens.Count);
        Instantiate(aliens[RNGsus], transform.position, Quaternion.identity);
        switch (RNGsus)
        {
            case 0:
                EventManager.invokeSubscribersTo_PlaySound_TankerRoar();
                break;
            case 1:
                EventManager.invokeSubscribersTo_PlaySound_GulperRoar();
                break;
            case 2:
                EventManager.invokeSubscribersTo_PlaySound_StreakerRoar();
                break;
            default:
                Debug.Log("No case for value " + RNGsus);
                break;
        }
    }

}
