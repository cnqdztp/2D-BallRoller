using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MapManager : MonoBehaviour
{
   public String mapTitle = "地图名";

   private void Awake()
   {
      var title =  GameObject.Find("GoalText");
      title.GetComponent<Text>().text = mapTitle;
   }
}
