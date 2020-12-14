﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using  UnityEngine.UI;

public class CheckNeighbors : MonoBehaviour
{   
   private int SelfIndex;
   private GridController _gridController;
   [SerializeField] Sprite CheckedImage,NormalImage;

   private void OnEnable()
   {
      _gridController = GetComponentInParent<GridController>();
   }

   public void Checkthem()
   {
      SelfIndex = int.Parse(transform.name);
      SetYourselfChecked();
      _gridController.checkNeighbors(SelfIndex);

   }


   void SetYourselfChecked()
   {
      GetComponent<Image>().sprite = CheckedImage;
      transform.tag = "Checked";
      
   }
}
