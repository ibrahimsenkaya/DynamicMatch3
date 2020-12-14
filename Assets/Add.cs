using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;

public class Add : MonoBehaviour
{
    private int Coloum;
    [SerializeField] private GameObject GridParent;
    [SerializeField] private GameObject _buttonPrefab;
    [SerializeField] private InputField _inputField;


    public void CreateGrid()
    {
        Destroy(GridParent.GetComponent<GridManager>());
        Coloum = int.Parse(_inputField.text);
        StartCoroutine(AddAgain());
    }

    IEnumerator AddAgain()
    {
        yield return new WaitForSeconds(.1f);
        GridManager on = GridParent.AddComponent<GridManager>();
        on.ColumnCount = Coloum;
        on.RowCount = Coloum;
        if (GridParent.transform.childCount != 0)
        {
            for (int i = 0; i < GridParent.transform.childCount; i++)
            {
                Destroy(GridParent.transform.GetChild(i).gameObject);
            }
        }

        var gridController = GridParent.GetComponent<GridController>();
      
        gridController.Buttons.Clear();
        for (int i = 0; i < Coloum * Coloum; i++)
        {
            GameObject tempBtn = Instantiate(_buttonPrefab, GridParent.transform);
             tempBtn.transform.name =i.ToString();
            gridController.Buttons.Add(tempBtn);
        }
        gridController.ChangeColomCount(Coloum);
    }
}