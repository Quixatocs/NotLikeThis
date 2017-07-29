using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerSpendController : MonoBehaviour {

    public List<GameObject> powerSupplies;
    public float spendDelay;
    public float spendInterval;

    void Start()
    {
        InvokeRepeating("ChooseSupplyAndSpendPower", spendDelay, spendInterval);
    }

    private void ChooseSupplyAndSpendPower()
    {
        int RNGsus = Mathf.FloorToInt(Random.value * powerSupplies.Count);
        powerSupplies[RNGsus].GetComponent<PowerSupplyController>().spendPower(1);
    }
}
