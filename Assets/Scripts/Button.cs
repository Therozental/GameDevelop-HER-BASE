using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class Button : MonoBehaviour
{

    public Text ButtonText;
    public bool isPressed = false;


    /* TODO: 
     * create method to signal a button isPressed and send it to the GameManager
     */

    public bool isButtonPressed()
    {
        if(isPressed)
        {
            return true;
        }
        return false;
    }
    
    public void OnButtonPressed()
    {
      // return true;
       isPressed = true;
    }

    public void ChangeToO()
    {
        ButtonText.text = "O";
    }

    public void ChangeToX()
    {
        ButtonText.text = "X";
    }

    /*
    public void XisPressed()
    {
        bool XisPressed = false;
        if (XisPressed == true)
        {
            ButtonText.text = "O";
        }
        else
        {
            ButtonText.text = "X";
        }
    }
    */
}
