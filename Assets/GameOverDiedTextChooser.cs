using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverDiedTextChooser : MonoBehaviour {

    public List<string> textOptions;
	
	void Awake () {
        int RNGsus = Mathf.FloorToInt(Random.value * textOptions.Count);

        GetComponent<Text>().text = "You Died " + textOptions[RNGsus] + ".";
    }

	
	
}
