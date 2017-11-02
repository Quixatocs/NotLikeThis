using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Class that controls the restarting of the game
/// </summary>
public class RestartControl : MonoBehaviour {
	

	void Update () {
        if (Input.GetButtonDown("Jump"))
        {
            //Application.LoadLevel(Application.loadedLevel);
            SceneManager.LoadScene("_Play");
        }
	}
}
