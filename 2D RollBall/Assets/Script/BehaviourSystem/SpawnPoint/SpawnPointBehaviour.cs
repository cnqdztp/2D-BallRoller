using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPointBehaviour : MonoBehaviour
{
    public bool isSpawnable = true;
    public Sprite spawnablePointSprite;
    public Sprite unspawnablePointSprite;
    private SpriteRenderer _spriteRenderer;

    private void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        
        _spriteRenderer.sprite = isSpawnable ? spawnablePointSprite : unspawnablePointSprite;
    }
}
