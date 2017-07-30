using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour {

    int aliensZapped = 0;


    void Start() {
        aliensZapped = 0;
    }


    void OnEnable()
    {
        EventManager.alienDeath += increaseScore;
    }

    void OnDisable()
    {
        EventManager.alienDeath -= increaseScore;
    }


    private void increaseScore(Vector3 unused)
    {
        aliensZapped += 1;

        EventManager.invokeSubscribersTo_ScoreChanged(aliensZapped);
    }

}
