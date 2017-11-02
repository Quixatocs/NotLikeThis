using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Class that updates the score UI upon receiving the score broadcast event
/// </summary>
public class ScoreDisplay : MonoBehaviour {

    void OnEnable()
    {
        EventManager.scoreChanged += updateUI;
    }

    void OnDisable()
    {
        EventManager.scoreChanged -= updateUI;
    }


    private void updateUI(int value)
    {
        if (value == 1)
        {
            GetComponent<Text>().text = value + " Kill";
        }
        else
        {
            GetComponent<Text>().text = value + " Kills";
        }
    } 


}
