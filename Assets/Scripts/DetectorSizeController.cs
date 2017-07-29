﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectorSizeController : MonoBehaviour {

	public float detectorMinSize = 2.0f;

    void OnEnable()
    {
        EventManager.totalPowerSupplyChangedTo += updateShootDetectorSize;
    }

    void OnDisable()
    {
        EventManager.totalPowerSupplyChangedTo -= updateShootDetectorSize;
    }

    //Updates the detector size based on the total Power Level available
    private void updateShootDetectorSize(int totalPowerLevel)
    {
        Vector2 newZise = GetComponent<BoxCollider2D>().size;
        newZise.x = totalPowerLevel + detectorMinSize;
        GetComponent<BoxCollider2D>().size = newZise;
    }


}
