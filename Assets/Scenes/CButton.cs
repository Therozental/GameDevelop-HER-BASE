using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CButton : MonoBehaviour
{
    int RowIndex = 0;
    int ColumnIndex = 0;
    public TMP_Text buttonText;
    public CButton(int RowIndex_, int ColumnIndex_)
    {
        RowIndex = RowIndex_;
        ColumnIndex = ColumnIndex_;
    }
    
    public void XisPressed()
    {
        bool XisPressed = false;
        if (XisPressed == true)
        {
            NewTextO();
        }
        else
        {
            NewTextX();
        }
    }

    public void NewTextO()
    {
        buttonText.text = "O";
    }
    public void NewTextX()
    {
        buttonText.text = "X";
    }
}

