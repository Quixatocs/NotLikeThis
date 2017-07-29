using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootTrigger : MonoBehaviour {

    private const string ALIEN_TAG = "Alien";

    void OnTriggerStay2D(Collider2D other)
    {

        if (other.tag == ALIEN_TAG)
            EventManager.invokeSubscribersTo_AlienDetected(other.transform);

    }
}
