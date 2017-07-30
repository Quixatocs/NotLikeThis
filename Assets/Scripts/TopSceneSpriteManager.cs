using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopSceneSpriteManager : MonoBehaviour {

    public GameObject blueChargeSpriteObject;
    public GameObject flickerController;

    // Shoot the Lazor!
    void OnEnable()
    {
        EventManager.shotFired += lightUpTheNight;
        EventManager.shotAbated += darkenTheNight;
        EventManager.towerPowered += powerSwitchVisuals;
    }

    void OnDisable()
    {
        EventManager.shotFired -= lightUpTheNight;
        EventManager.shotAbated -= darkenTheNight;
        EventManager.towerPowered -= powerSwitchVisuals;
    }

    private void lightUpTheNight() {
        blueChargeSpriteObject.SetActive(true);
    }

    private void darkenTheNight()
    {
        blueChargeSpriteObject.SetActive(false);
    }

    private void powerSwitchVisuals(bool state) {
        flickerController.SetActive(state); 
    }

}
