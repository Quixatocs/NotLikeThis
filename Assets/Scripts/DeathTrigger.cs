using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathTrigger : MonoBehaviour {

    private const string ALIEN_TAG = "Alien";

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == ALIEN_TAG)
            EventManager.invokeSubscribersTo_GameOver();

    }
}
