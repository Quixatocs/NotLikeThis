using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour {

    private const string MAGNET_TAG = "Magnet";

    private bool isCarrying = false;

    void OnEnable()
    {
        EventManager.drop += Drop;
    }

    void OnDisable()
    {
        EventManager.drop -= Drop;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        switch (other.tag) {

            case MAGNET_TAG:
                if (!isCarrying)
                {
                    isCarrying = true;
                    transform.SetParent(other.transform);
                    transform.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Kinematic;
                    transform.GetComponent<Rigidbody2D>().simulated = false;
                }
                break;
        }
        
    }

    private void Drop()
    {
        isCarrying = false;
        transform.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
        transform.GetComponent<Rigidbody2D>().simulated = true;
        
    }

}
