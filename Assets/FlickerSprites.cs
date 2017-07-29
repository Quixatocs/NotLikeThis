using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlickerSprites : MonoBehaviour {

    public GameObject electricFlow1;
    public GameObject electricFlow2;

    void Start() {
        StartCoroutine(flickerE1());
        StartCoroutine(flickerE2());
    }

    private IEnumerator flickerE1()
    {
        float randomWait1 = Random.Range(0.01f, 0.2f);
        float randomWait2 = Random.Range(0.01f, 0.2f);
        electricFlow1.SetActive(Random.value * 2 < 1);
        yield return new WaitForSeconds(randomWait1);
        electricFlow1.SetActive(Random.value * 2 < 1);
        yield return new WaitForSeconds(randomWait2);
        StopCoroutine(flickerE1());
        StartCoroutine(flickerE1());
    }

    private IEnumerator flickerE2()
    {
        float randomWait1 = Random.Range(0.01f, 0.2f);
        float randomWait2 = Random.Range(0.01f, 0.2f);
        electricFlow2.SetActive(Random.value * 2 < 1);
        yield return new WaitForSeconds(randomWait1);
        electricFlow2.SetActive(Random.value * 2 < 1);
        yield return new WaitForSeconds(randomWait2);
        StopCoroutine(flickerE2());
        StartCoroutine(flickerE2());
    }
}
