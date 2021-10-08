using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallInteractBehaviour : MonoBehaviour
{
    private LifespanBehaviour _lifespanBehaviour;
    private BallSoundBehaviour _ballSoundBehaviour;
    private Controller _controller;

    private void Awake()
    {
        _lifespanBehaviour = GetComponent<LifespanBehaviour>();
        _ballSoundBehaviour = GetComponent<BallSoundBehaviour>();
        _controller = GetComponent<Controller>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Hole"))
        {
            _ballSoundBehaviour.PlayHoleSE();
            _lifespanBehaviour.OnDropHole(other);
        }
        else if (other.CompareTag("Finish"))
        {
            _ballSoundBehaviour.PlayVictorySE();
        }
    }
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Obstacle"))
        {
            _ballSoundBehaviour.PlayObstacleSE();
        }
    }
        
}
