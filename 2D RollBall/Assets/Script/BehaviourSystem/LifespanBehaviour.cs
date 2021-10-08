using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifespanBehaviour : MonoBehaviour
{
    private GameObject gameManager;
    private BallManager ballManager;
    private void Awake()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager");
        ballManager = gameManager.GetComponent<BallManager>();
    }



    public void OnDropHole()
    {
        this.GetComponent<Controller>().enabled = false;
        StartCoroutine(nameof(InstantiateNewBall));
    }
    
    private IEnumerator InstantiateNewBall()
    {
        gameObject.GetComponent<Renderer>().enabled = false;
        yield return new WaitForSeconds(0.5f);
        ballManager.InstantiateBall();
        Destroy(gameObject);
    }
}
