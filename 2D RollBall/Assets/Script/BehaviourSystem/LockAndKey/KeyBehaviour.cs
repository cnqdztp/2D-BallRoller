using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class KeyBehaviour : MonoBehaviour
{
    public GameObject lockItem;

    private void Start()
    {
        transform.DOMove(this.transform.position + new Vector3(0, 0.25f, 0f), 1f).SetEase(Ease.InOutQuart).SetLoops(-1,LoopType.Yoyo);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (lockItem != null)
        {
            transform.DOMove(lockItem.transform.position,1f).OnComplete(FadeOut).SetEase(Ease.InOutQuart);
            other.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            other.GetComponent<Transform>().DOMove(this.transform.position, 0.3f);
        }
        else
        {
            Debug.Log("No GO assigned to the key");
        }
    }

    private void FadeOut()
    {
        lockItem.GetComponent<LockBehaviour>().Unlock();
        lockItem.GetComponent<LockBehaviour>().PlayUnlockSE();
        this.GetComponent<SpriteRenderer>().DOFade(0.0f, 0.5f).OnComplete(DestroyMe);
        
    }

    private void DestroyMe()
    {
        Destroy(gameObject);
    }
}
