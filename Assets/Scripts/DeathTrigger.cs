﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathTrigger : MonoBehaviour {

    private const string ALIEN_TAG = "Alien";

    public GameObject deathUI;

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == ALIEN_TAG)
        {
            deathUI.SetActive(true);
            EventManager.invokeSubscribersTo_GameOver();
        }
    

    }
}
