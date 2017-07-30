using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour {


    public static EventManager instance = null;

    public delegate void Drop();
    public static event Drop drop;

    public delegate void GameOver();
    public static event GameOver gameOver;

    public delegate void AlienDetected(Transform alienTarget);
    public static event AlienDetected alienDetected;

    public delegate void PowerSupplyChanged();
    public static event PowerSupplyChanged powerSupplyChanged;

    public delegate void TotalPowerSupplyChangedTo(int totalAmount);
    public static event TotalPowerSupplyChangedTo totalPowerSupplyChangedTo;

    public delegate void AlienDeath(Vector3 positionOfDeath);
    public static event AlienDeath alienDeath;

    public delegate void ShotFired();
    public static event ShotFired shotFired;

    public delegate void ShotAbated();
    public static event ShotAbated shotAbated;

    public delegate void TowerPowered(bool state);
    public static event TowerPowered towerPowered;

    public delegate void ScoreChanged(int value);
    public static event ScoreChanged scoreChanged;


    void Awake()
    {
        singleton();
    }

    void singleton()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);
        DontDestroyOnLoad(gameObject);
    }


    public static void invokeSubscribersTo_Drop()
    {
        drop();
    }


    public static void invokeSubscribersTo_GameOver()
    {
        Debug.Log("GameOver");
        gameOver();
    }

    public static void invokeSubscribersTo_AlienDetected(Transform alienTarget)
    {
        alienDetected(alienTarget);
    }

    public static void invokeSubscribersTo_PowerSupplyChanged()
    {
        powerSupplyChanged();
    }

    public static void invokeSubscribersTo_TotalPowerSupplyChangedTo(int totalAmount)
    {
        totalPowerSupplyChangedTo(totalAmount);
    }

    public static void invokeSubscribersTo_AlienDeath(Vector3 positionOfDeath)
    {
        alienDeath(positionOfDeath);
    }

    public static void invokeSubscribersTo_ShotFired()
    {
        shotFired();
    }

    public static void invokeSubscribersTo_ShotAbated()
    {
        shotAbated();
    }

    public static void invokeSubscribersTo_TowerPowered(bool state)
    {
        towerPowered(state);
    }

    public static void invokeSubscribersTo_ScoreChanged(int value)
    {
        scoreChanged(value);
    }



}
