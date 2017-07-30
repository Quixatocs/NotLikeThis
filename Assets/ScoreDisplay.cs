using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
