using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {

    public AudioSource sfxSource;
    public AudioSource mainMusicSource;
    public AudioSource gameOverMusicSource;

    public AudioClip gameOverSound;
    public AudioClip jumpSound;
    public AudioClip pickUpSound;
    public AudioClip dropSound;
    public AudioClip depositSound;
    public AudioClip tankerRoarSound;
    public AudioClip gulperRoarSound;
    public AudioClip streakerRoarSound;
    public AudioClip zap1Sound;
    public AudioClip zap2Sound;
    public AudioClip zap3Sound;
    public AudioClip enemyDestroyedSound;
    public AudioClip powerDownSound;
    public AudioClip unpoweredSound;


    void OnEnable()
    {
        EventManager.gameOver += playSound_GameOver_AndChangeMusic;
        EventManager.playSound_Jump += playSound_Jump;
        EventManager.playSound_PickUp += playSound_pickUp;
        EventManager.drop += playSound_Drop;
        EventManager.playSound_Deposit += playSound_Deposit;
        EventManager.playSound_tankerRoar += playSound_tankerRoar;
        EventManager.playSound_GulperRoar += playSound_GulperRoar;
        EventManager.playSound_StreakerRoar += playSound_StreakerRoar;
        EventManager.shotFired += playSound_Zap;
        EventManager.alienDeath += playSound_EnemyDestroyed;
        EventManager.playSound_PowerDownSound += playSound_PowerDownSound;
        EventManager.playSound_UnpoweredSound += playSound_UnpoweredSound;
    }

    void OnDisable()
    {
        EventManager.gameOver -= playSound_GameOver_AndChangeMusic;
        EventManager.playSound_Jump -= playSound_Jump;
        EventManager.playSound_PickUp -= playSound_pickUp;
        EventManager.drop -= playSound_Drop;
        EventManager.playSound_Deposit -= playSound_Deposit;
        EventManager.playSound_tankerRoar -= playSound_tankerRoar;
        EventManager.playSound_GulperRoar -= playSound_GulperRoar;
        EventManager.playSound_StreakerRoar -= playSound_StreakerRoar;
        EventManager.shotFired -= playSound_Zap;
        EventManager.alienDeath -= playSound_EnemyDestroyed;
        EventManager.playSound_PowerDownSound -= playSound_PowerDownSound;
        EventManager.playSound_UnpoweredSound -= playSound_UnpoweredSound;
    }

    private void playSound_GameOver_AndChangeMusic() 
    {
        gameOverMusicSource.Play();
        mainMusicSource.Stop();
        sfxSource.PlayOneShot(gameOverSound);
    }

    private void playSound_Jump()
    {
        sfxSource.PlayOneShot(jumpSound);
    }

    private void playSound_pickUp()
    {
        sfxSource.PlayOneShot(pickUpSound);
    }

    private void playSound_Drop()
    {
        sfxSource.PlayOneShot(dropSound);
    }

    private void playSound_Deposit()
    {
        sfxSource.PlayOneShot(depositSound);
    }

    private void playSound_Zap()
    {
        int RNGsus = Mathf.FloorToInt(Random.value * 3);
        switch (RNGsus)
        {
            case 0:
                sfxSource.PlayOneShot(zap1Sound);
                break;
            case 1:
                sfxSource.PlayOneShot(zap2Sound);
                break;
            case 2:
                sfxSource.PlayOneShot(zap3Sound);
                break;
            default:
                Debug.Log("No case for value " + RNGsus);
                break;
        }
    }

    private void playSound_EnemyDestroyed(Vector3 unused)
    {
        sfxSource.PlayOneShot(enemyDestroyedSound);
    }

    private void playSound_tankerRoar()
    {
        sfxSource.PlayOneShot(tankerRoarSound);
    }

    private void playSound_GulperRoar()
    {
        sfxSource.PlayOneShot(gulperRoarSound);
    }

    private void playSound_StreakerRoar()
    {
        sfxSource.PlayOneShot(streakerRoarSound);
    }

    private void playSound_PowerDownSound()
    {
        sfxSource.PlayOneShot(powerDownSound);
    }

    private void playSound_UnpoweredSound()
    {
        sfxSource.PlayOneShot(unpoweredSound);
    }





}
