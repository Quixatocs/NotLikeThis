using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoryTextController : MonoBehaviour {

    public float timeBetweenText = 5f;

    public List<string> storyTexts;

    private int currentTextIndex = 0;
    private Text displayText;

    void Awake() {
        currentTextIndex = 0;
    }

    void Start() {
        displayText = GetComponent<Text>();
        InvokeRepeating("runTheStoryText", 0f, timeBetweenText);
    }

    private void runTheStoryText() {
        displayText.text = storyTexts[currentTextIndex];
        currentTextIndex++;
        if (currentTextIndex > storyTexts.Count - 1) {
            Destroy(transform.parent.gameObject, timeBetweenText);
        }
    }

}
