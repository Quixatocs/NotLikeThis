using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerSupplyController : MonoBehaviour {

    private const string LOW_BAT_TAG = "LowBat";
    private const string MED_BAT_TAG = "MedBat";
    private const string HIGH_BAT_TAG = "HighBat";

    public GameObject supplyVisuals;

    // 3 = full
    // 2 = mid
    // 1 = low
    // 0 = empty
    private int powerSupplyReserveLevel = 3;

    public Sprite fullSprite;
    public Sprite midSprite;
    public Sprite lowSprite;
    public Sprite emptySprite;

    void OnTriggerEnter2D(Collider2D other)
    {
        switch (other.tag)
        {

            case LOW_BAT_TAG:
                Destroy(other.gameObject);
                changeReserves(1);
                break;
            case MED_BAT_TAG:
                Destroy(other.gameObject);
                changeReserves(2);
                break;
            case HIGH_BAT_TAG:
                Destroy(other.gameObject);
                changeReserves(3);
                break;
        }

    }

    public int getPowerSupplyReserveLevel() {
        return powerSupplyReserveLevel;
    }

    public void spendPower(int amount)
    {
        Debug.Log("spendPower called");
        changeReserves(-amount);
    }

    private void changeReserves(int amount)
    {
        powerSupplyReserveLevel += amount;
        if (powerSupplyReserveLevel > 3)
            powerSupplyReserveLevel = 3;
        if (powerSupplyReserveLevel < 0)
            powerSupplyReserveLevel = 0;

        updateSprites(powerSupplyReserveLevel);
    }

    private void updateSprites(int reserveLevel)
    {

        switch (reserveLevel) {

            case 0:
                supplyVisuals.GetComponent<SpriteRenderer>().sprite = emptySprite;
                break;
            case 1:
                supplyVisuals.GetComponent<SpriteRenderer>().sprite = lowSprite;
                break;
            case 2:
                supplyVisuals.GetComponent<SpriteRenderer>().sprite = midSprite;
                break;
            case 3:
                supplyVisuals.GetComponent<SpriteRenderer>().sprite = fullSprite;
                break;
            default:
                Debug.Log("no case for reserve level " + reserveLevel);
                break;
        }
    }


}
