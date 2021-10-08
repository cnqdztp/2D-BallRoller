using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Serialization;
using Random = UnityEngine.Random;

public class BallSoundBehaviour : MonoBehaviour
{
    private AudioSource soundSource;
    [FormerlySerializedAs("HoleSound")] [SerializeField] private AudioClip[] holeSound;
    [FormerlySerializedAs("WallSound")] [SerializeField] private AudioClip[] wallSound;
    [SerializeField] private AudioClip[] victorySound;
    private bool isInPlay = false;
    private int holeSoundCount;
    private int wallSoundCount;
    private int victorySoundCount;
    private void Awake()
    {
        soundSource = gameObject.GetComponent<AudioSource>();
        holeSoundCount = holeSound.Length;
        wallSoundCount = wallSound.Length;
        victorySoundCount = victorySound.Length;
    }
    
    public void PlayHoleSE()
    {
        soundSource.PlayOneShot(holeSound[Random.Range(0,holeSoundCount-1)]);
        isInPlay = true;
        InvokeRepeating(nameof(CheckPlayState),0.5f,0.1f);
    }

    public void PlayObstacleSE()
    {
        soundSource.PlayOneShot(wallSound[Random.Range(0,wallSoundCount-1)]);
        isInPlay = true;
        InvokeRepeating(nameof(CheckPlayState),0.5f,0.1f);
    }

    public void PlayVictorySE()
    {
        soundSource.PlayOneShot(victorySound[Random.Range(0,victorySoundCount-1)]);
        isInPlay = true;
        InvokeRepeating(nameof(CheckPlayState),0.5f,0.1f);
    }
    
    private void CheckPlayState()
    {
        if (!soundSource.isPlaying)
        {
            isInPlay = false;
            CancelInvoke(nameof(CheckPlayState));
        }
    }
    
}
