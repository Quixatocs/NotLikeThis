﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienSpriteAnimation : MonoBehaviour {

    public Sprite movement1;
    public Sprite movement2;

    public float flickerSpeed;

    private WaitForSeconds wait;
    private SpriteRenderer spriteRenderer;

    void Start() {
        spriteRenderer = GetComponent<SpriteRenderer>();
        wait = new WaitForSeconds(flickerSpeed);
        CancelInvoke();
        Invoke("flickerStage1", flickerSpeed);
    }

    private void flickerStage1()
    {
        spriteRenderer.sprite = movement1;
        Invoke("flickerStage2", flickerSpeed);

    }

    private void flickerStage2()
    {
        spriteRenderer.sprite = movement2;
        Invoke("flickerStage1", flickerSpeed);

    }
}
