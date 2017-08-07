using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickToPlayer : MonoBehaviour {

    public GameObject target;

    public float xOffset = 0;
    public float yOffset = 0;


    void LateUpdate() {
        transform.position = 
            new Vector3(target.transform.position.x + xOffset,
                        target.transform.position.y + yOffset,
                        target.transform.position.z);
    }
}
