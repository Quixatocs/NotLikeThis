using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Class to control the random spending of power from a bank when the Tower loses power.
/// </summary>
public class PowerSpendController : MonoBehaviour {

    public List<GameObject> powerSupplies;
    public float spendDelay;
    public float spendInterval;

    private int lastRecordedTotalPowerReserves = 0;

    void OnEnable()
    {
        EventManager.powerSupplyChanged += GetAndRecordTotalPowerReserves;
    }

    void OnDisable()
    {
        EventManager.powerSupplyChanged -= GetAndRecordTotalPowerReserves;
    }

    void Start()
    {
        InvokeRepeating("ChooseSupplyAndSpendPower", spendDelay, spendInterval);
    }

    private void ChooseSupplyAndSpendPower()
    {
        int RNGsus = Mathf.FloorToInt(Random.value * powerSupplies.Count);
        powerSupplies[RNGsus].GetComponent<PowerSupplyController>().spendPower(1);
        EventManager.invokeSubscribersTo_PlaySound_PowerDownSound();
    }

    private void GetAndRecordTotalPowerReserves()
    {
        //Clean for new record
        lastRecordedTotalPowerReserves = 0;
        bool isAnySupplyEmpty = false;

        foreach (GameObject obj in powerSupplies)
        {
            int supplyLevel = obj.GetComponent<PowerSupplyController>().getPowerSupplyReserveLevel();
            if (supplyLevel == 0)
                isAnySupplyEmpty = true;
            lastRecordedTotalPowerReserves += supplyLevel;
        }

        if (isAnySupplyEmpty)
            EventManager.invokeSubscribersTo_PlaySound_UnpoweredSound();

        EventManager.invokeSubscribersTo_TowerPowered(!isAnySupplyEmpty);

        EventManager.invokeSubscribersTo_TotalPowerSupplyChangedTo(lastRecordedTotalPowerReserves);
    } 

}
