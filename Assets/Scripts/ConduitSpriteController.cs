using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Class to controll the colour of the conduit sprites in the UI.
/// </summary>
public class ConduitSpriteController : MonoBehaviour {

    public Color onColor; // = new Color(27, 134, 255);
    public Color offColor; // = new Color(25, 25, 25);

    void OnEnable()
    {
        EventManager.towerPowered += controlConduitColor;
    }

    void OnDisable()
    {
        EventManager.towerPowered -= controlConduitColor;
    }

    private void controlConduitColor(bool isOn) {
        if (isOn)
        {
            GetComponent<SpriteRenderer>().color = onColor;
        }
        else
        {
            GetComponent<SpriteRenderer>().color = offColor;
        }
    }
}
