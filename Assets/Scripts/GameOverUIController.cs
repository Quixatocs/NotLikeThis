using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Class to activate the Game Over UI upon the broadcast of the gameover event
/// </summary>
public class GameOverUIController : MonoBehaviour {

    public GameObject gameOverUI;

    void OnEnable()
    {
        EventManager.gameOver += activateUI;
    }

    void OnDisable()
    {
        EventManager.gameOver -= activateUI;
    }


    private void activateUI() {
        gameOverUI.SetActive(true);
        //EventManager.invokeSubscribersTo_PushFinalScore();
    }

}
