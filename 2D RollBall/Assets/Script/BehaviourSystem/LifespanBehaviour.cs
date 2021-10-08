using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class LifespanBehaviour : MonoBehaviour
{
    private GameObject gameManager;
    private BallManager ballManager;
    private GameObject hole;
    private void Awake()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager");
        ballManager = gameManager.GetComponent<BallManager>();
    }



    public void OnDropHole(Collider2D _hole)
    {
        this.GetComponent<Controller>().enabled = false;
        hole = _hole.gameObject;
        StartCoroutine(nameof(InstantiateNewBall));
    }
    
    private IEnumerator InstantiateNewBall()
    {
        transform.DOMove(hole.transform.position, 0.4f);
        transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        this.GetComponent<SpriteRenderer>().DOFade(0, 0.3f);
        // gameObject.GetComponent<Renderer>().enabled = false;
        yield return new WaitForSeconds(0.5f);
        ballManager.InstantiateBall();
        Destroy(gameObject);
    }
}
