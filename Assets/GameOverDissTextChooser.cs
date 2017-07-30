using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverDissTextChooser : MonoBehaviour {

    public List<string> textOptions;

    void Awake()
    {
        int RNGsus = Mathf.FloorToInt(Random.value * textOptions.Count);

        GetComponent<Text>().text = textOptions[RNGsus] + ".";
    }
}
