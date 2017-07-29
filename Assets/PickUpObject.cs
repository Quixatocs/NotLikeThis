using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpObject : MonoBehaviour {

    public GameObject magnetHolder;


    void Update() {

        if (Input.GetKey(KeyCode.W))
        {
            magnetHolder.SetActive(true);
        }
        else
        {
            if (magnetHolder.transform.childCount > 0) { 
                magnetHolder.transform.GetChild(0).SetParent(null);
                EventManager.invokeSubscribersTo_Drop();
            }
            magnetHolder.SetActive(false);
        }

    }



}
