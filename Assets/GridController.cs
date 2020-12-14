using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridController : MonoBehaviour
{
    public List<GameObject> Buttons;

    private void Update()
    {
        Debug.Log(GetComponent<GridManager>().ColumnCount);
    }
}
