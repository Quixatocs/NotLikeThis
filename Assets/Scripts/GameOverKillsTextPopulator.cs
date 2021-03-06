﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Class to present Game Over data text in the UI
/// </summary>
public class GameOverKillsTextPopulator : MonoBehaviour {


    void OnEnable()
    {
        EventManager.publishFinalScore += updateUI;
    }

    void OnDisable()
    {
        EventManager.publishFinalScore -= updateUI;
    }

    void Awake()
    {
        GetComponent<Text>().text = "You took some Ktharns with you this day.";
    }

    private void updateUI(int score)
    {
        GetComponent<Text>().text = "You took " + score + " Ktharns with you this day.";
    }
}
