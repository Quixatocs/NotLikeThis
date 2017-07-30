using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    void Start()
    {
        Time.timeScale = 1;
    }

    void OnEnable()
    {
        EventManager.gameOver += stopTime;
    }

    void OnDisable()
    {
        EventManager.gameOver -= stopTime;
    }

    private void stopTime() {

        Time.timeScale = 0;
    }

}
