using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSystemManager : MonoBehaviour
{
    private CanvasGroup successCanvas;
    private MapManager _mapManager;
    public SceneSwitchManager _sceneSwitchManager;
    
    
    private void Awake()
    {
        successCanvas = GameObject.Find("SuccessCanvas").GetComponent<CanvasGroup>();
        successCanvas.alpha = 0;
        _mapManager = gameObject.GetComponent<MapManager>();
        _sceneSwitchManager = gameObject.GetComponent<SceneSwitchManager>();
    }

    public void OnSuccess()
    {
        successCanvas.DOFade(1f, 0.5f);
    }
    
    //TODO Make sure scene switch does not rely on build index
    
    
}
