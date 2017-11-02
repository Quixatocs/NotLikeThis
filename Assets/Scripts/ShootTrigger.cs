using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Class that attaches to the tower hitbox and checks for aliens. If it finds aliens it shoots
/// </summary>
public class ShootTrigger : MonoBehaviour {

    private const string ALIEN_TAG = "Alien";

    void OnTriggerStay2D(Collider2D other)
    {

        if (other.tag == ALIEN_TAG)
            EventManager.invokeSubscribersTo_AlienDetected(other.transform);

    }
}
