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

    public delegate void PublishFinalScore(int score);
    public static event PublishFinalScore publishFinalScore;

    public delegate void PushFinalScore();
    public static event PushFinalScore pushFinalScore;

    public delegate void PlaySound_Jump();
    public static event PlaySound_Jump playSound_Jump;

    public delegate void PlaySound_PickUp();
    public static event PlaySound_PickUp playSound_PickUp;

    public delegate void PlaySound_Deposit();
    public static event PlaySound_Deposit playSound_Deposit;

    public delegate void PlaySound_TankerRoar();
    public static event PlaySound_TankerRoar playSound_tankerRoar;

    public delegate void PlaySound_GulperRoar();
    public static event PlaySound_GulperRoar playSound_GulperRoar;

    public delegate void PlaySound_StreakerRoar();
    public static event PlaySound_StreakerRoar playSound_StreakerRoar;

    public delegate void PlaySound_PowerDownSound();
    public static event PlaySound_PowerDownSound playSound_PowerDownSound;

    public delegate void PlaySound_UnpoweredSound();
    public static event PlaySound_UnpoweredSound playSound_UnpoweredSound;





    public static void invokeSubscribersTo_Drop()
    {
        drop();
    }


    public static void invokeSubscribersTo_GameOver()
    {
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

    public static void invokeSubscribersTo_PublishFinalScore(int score)
    {
        publishFinalScore(score);
    }

    public static void invokeSubscribersTo_PushFinalScore()
    {
        pushFinalScore();
    }


    public static void invokeSubscribersTo_PlaySound_Jump()
    {
        playSound_Jump();
    }

    public static void invokeSubscribersTo_PlaySound_PickUp()
    {
        playSound_PickUp();
    }

    public static void invokeSubscribersTo_PlaySound_Deposit()
    {
        playSound_Deposit();
    }

    public static void invokeSubscribersTo_PlaySound_TankerRoar()
    {
        playSound_tankerRoar();
    }

    public static void invokeSubscribersTo_PlaySound_GulperRoar()
    {
        playSound_GulperRoar();
    }

    public static void invokeSubscribersTo_PlaySound_StreakerRoar()
    {
        playSound_StreakerRoar();
    }

    public static void invokeSubscribersTo_PlaySound_PowerDownSound()
    {
        playSound_PowerDownSound();
    }

    public static void invokeSubscribersTo_PlaySound_UnpoweredSound()
    {
        playSound_UnpoweredSound();
    }



}
