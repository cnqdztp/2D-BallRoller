using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class FlagAppearance : MonoBehaviour
{
   private Vector3 position;
   public float offset;

   private void Awake()
   {
      position = transform.position;
   }

   private void Start()
   {
      transform.DOMoveY(position.y + offset, 0.5f).SetEase(Ease.OutQuart).SetLoops(4, LoopType.Yoyo);
      this.GetComponent<SpriteRenderer>().DOFade(0.4f, 0.5f).SetEase(Ease.InOutCubic).SetLoops(4, LoopType.Yoyo);
   }
}
