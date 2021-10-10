using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MapManager : MonoBehaviour
{
   public String mapTitle = "地图名";
   [TextArea]
   public String mapDescription = "";
   public int levelCode;
   public int levelSubCode;

   private Text titleUI;
   private TextMeshProUGUI descriptionUI;
   
   private void Awake()
   {
      titleUI =  GameObject.Find("GoalText").GetComponent<Text>();
      descriptionUI = GameObject.Find("DescriptionTextTMP").GetComponent<TextMeshProUGUI>();
   }

   private void Start()
   {
      titleUI.text = mapTitle;
      descriptionUI.text = mapDescription;
   }
}
