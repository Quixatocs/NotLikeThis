using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    }

    private void GetAndRecordTotalPowerReserves()
    {
        //Clean for new record
        lastRecordedTotalPowerReserves = 0;

        foreach (GameObject obj in powerSupplies)
        {
            lastRecordedTotalPowerReserves += obj.GetComponent<PowerSupplyController>().getPowerSupplyReserveLevel();
        }

        Debug.Log(lastRecordedTotalPowerReserves);
        EventManager.invokeSubscribersTo_TotalPowerSupplyChangedTo(lastRecordedTotalPowerReserves);
    } 

}
