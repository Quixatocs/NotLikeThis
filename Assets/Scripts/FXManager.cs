using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FXManager : MonoBehaviour {

    public GameObject alienDeathFX;


    void OnEnable()
    {
        EventManager.alienDeath += spawnAlienDeathEffect;
    }

    void OnDisable()
    {
        EventManager.alienDeath -= spawnAlienDeathEffect;
    }


    private void spawnAlienDeathEffect(Vector3 positionOfDeath) {
        GameObject destroyMe = Instantiate(alienDeathFX, new Vector3(positionOfDeath.x, positionOfDeath.y + 1f, -2f), Quaternion.Euler(new Vector3(90f, 0f, 0f)));
        Destroy(destroyMe, 5f);
    }


}
