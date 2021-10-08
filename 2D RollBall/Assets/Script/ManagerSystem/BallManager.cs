using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallManager : MonoBehaviour
{
    private GameObject[] BallList = {};
    public GameObject BallPrefab;
    [SerializeField] GameObject SpawnPoint;
    private bool isVictory;
    [SerializeField] private float OverrideControllerSpeed = 10;

    private void Awake()
    {
        SpawnPoint = GameObject.FindGameObjectWithTag("Respawn");
    }

    private void Start()
    {
        InstantiateBall();
    }

    public void InstantiateBall()
    {
        var newBall = Instantiate(BallPrefab, SpawnPoint.transform.position, new Quaternion(0, 0, 0, 0));
        newBall.GetComponent<Controller>().speed = OverrideControllerSpeed;
        // RegisterBall(newBall);
    }
    
    public int CheckBallNum()
    {
        int ballNum = BallList.Length;
        return ballNum;
    }

    public void RegisterBall(GameObject _ball)
    {
        BallList[BallList.Length] = _ball;
    }

    public void RemoveRegister(GameObject _ball)
    {
        throw new NotImplementedException();
    }
    
}
