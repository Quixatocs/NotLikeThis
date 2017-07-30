using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartControl : MonoBehaviour {
	

	void Update () {
        if (Input.GetButtonDown("Jump"))
        {
            //Application.LoadLevel(Application.loadedLevel);
            SceneManager.LoadScene("_Play");
        }
	}
}
