using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridController : MonoBehaviour
{
    public List<GameObject> Buttons;
    [SerializeField] int coloumCount;

    public void ChangeColomCount(int aIndex)
    {
        coloumCount = aIndex;
    }

    public void checkNeighbors(int c)
    {
        
    }
}
