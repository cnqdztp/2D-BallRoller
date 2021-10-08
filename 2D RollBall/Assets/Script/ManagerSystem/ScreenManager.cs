using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenManager : MonoBehaviour
{
    public bool forceLandscape = true;
    // Start is called before the first frame update
    void Start()
    {
        if (forceLandscape)
        {
            Screen.orientation = ScreenOrientation.LandscapeLeft;
        }
        
        
    }
}
