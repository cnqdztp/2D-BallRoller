using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using Random = UnityEngine.Random;

public class LockBehaviour : MonoBehaviour
{
    private AudioSource _audioSource;
    [SerializeField] private AudioClip[] unlockSound;
    private bool isInPlay = false;

    private int unlockSoundCount;

    private void Awake()
    {
        unlockSoundCount = unlockSound.Length;
        _audioSource = GetComponent<AudioSource>();
    }

    public void Unlock()
    {
        GetComponent<SpriteRenderer>().DOFade(0, 0.5f);
        GetComponent<Collider2D>().enabled = false;
    }
    
    public void PlayUnlockSE()
    {
        _audioSource.PlayOneShot(unlockSound[Random.Range(0,unlockSoundCount-1)]);
        isInPlay = true;
        InvokeRepeating(nameof(CheckPlayState),0.5f,0.1f);
    }
    
    private void CheckPlayState()
    {
        if (!_audioSource.isPlaying)
        {
            isInPlay = false;
            CancelInvoke(nameof(CheckPlayState));
        }
    }
}
