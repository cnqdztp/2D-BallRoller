using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallManager : MonoBehaviour
{
    private GameObject[] BallList = {};
    public GameObject BallPrefab;
    [SerializeField] GameObject SpawnPoint;
    private bool isVictory;
    [SerializeField] private float OverrideControllerSpeed = 10;
    [SerializeField] private SceneSwitchManager _sceneSwitchManager;
    private bool isSpawnableScene;

    private GameObject newBall;
    public Slider sensitivitySlider;
    
    private void Awake()
    {
        _sceneSwitchManager = GetComponent<SceneSwitchManager>();
        SpawnPoint = GameObject.FindGameObjectWithTag("Respawn");
        isSpawnableScene = SpawnPoint.GetComponent<SpawnPointBehaviour>().isSpawnable;
    }

    private void Start()
    {
        InstantiateBall();
    }

    public void onBallDrop()
    {
        if (isSpawnableScene)
        {
            InstantiateBall();
        }
        else
        {
            _sceneSwitchManager.Reload();
        }
    }
    
    public void InstantiateBall()
    {
        newBall = Instantiate(BallPrefab, SpawnPoint.transform.position, new Quaternion(0, 0, 0, 0));
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

    public void ReadSensitivityFromSlider()
    {
        OverrideControllerSpeed = sensitivitySlider.value;
        newBall.GetComponent<Controller>().speed = OverrideControllerSpeed;
    }
    
    
}
