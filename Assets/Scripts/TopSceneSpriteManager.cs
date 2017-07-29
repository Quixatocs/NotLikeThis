using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopSceneSpriteManager : MonoBehaviour {

    public GameObject blueChargeSpriteObject;

    // Shoot the Lazor!
    void OnEnable()
    {
        EventManager.shotFired += lightUpTheNight;
        EventManager.shotAbated += darkenTheNight;
    }

    void OnDisable()
    {
        EventManager.shotFired -= lightUpTheNight;
        EventManager.shotAbated -= darkenTheNight;
    }

    private void lightUpTheNight() {

        blueChargeSpriteObject.SetActive(true);

    }

    private void darkenTheNight()
    {

        blueChargeSpriteObject.SetActive(false);

    }

}
