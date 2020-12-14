using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using  UnityEngine.UI;

public class GridManager : GridLayoutGroup
{
    private float width;
    public int ColumnCount = 10;
    public int RowCount = 10;
    // Start is called before the first frame update
    void Start()
    {
        //
        // // width = this.gameObject.GetComponent<RectTransform>().rect.width;
        // //      Debug.Log(width);
        // // Vector2 newSize = new Vector2(width / 2, width / 2);
        // // this.gameObject.GetComponent<GridLayoutGroup>().cellSize = newSize;
        // float width;
        // GridLayoutGroup lg;
        // lg = GetComponent<GridLayoutGroup>();
        // width = gameObject.GetComponent<RectTransform>().rect.width;
        // float sizeButt = lg.cellSize.x + lg.spacing.x;
        // int hSize = Mathf.FloorToInt(width / sizeButt);
        // lg.constraintCount = hSize;
        SetLayoutHorizontal();
    }
    
  
 
 
    public override void SetLayoutHorizontal()
    {
        UpdateCellSize();
        base.SetLayoutHorizontal();
    }
 
    public override void SetLayoutVertical()
    {
        UpdateCellSize();
        base.SetLayoutVertical();
    }
 
    private void UpdateCellSize()
    {        
        float x = (rectTransform.rect.size.x - padding.horizontal - spacing.x*(ColumnCount - 1)) / ColumnCount;
        float y = (rectTransform.rect.size.y - padding.vertical - spacing.y * (RowCount - 1)) / RowCount;
        this.constraint = Constraint.FixedColumnCount;
        this.constraintCount = ColumnCount;
        this.cellSize = new Vector2(x,y);    
    }

}
