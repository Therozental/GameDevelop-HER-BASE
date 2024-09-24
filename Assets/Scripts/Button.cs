using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class Button : MonoBehaviour
{

    public TextMeshProUGUI ButtonText;
    public bool isPressed = false;
    public GameManager gameManager;
    string buttonMode;
    


    /* TODO: 
     * create method to signal a button isPressed and send it to the GameManager
     */

    public void OnButtonClick()
    {
        if(isPressed == true)
        {
            return;
        }
       ChangeText();
       gameManager.SwitchTurns();
       isPressed = true;
       Debug.Log("button was pressed");
        gameManager.
    }

    public void ChangeText()
    {
        if(gameManager.isXTurn() == true)
        {
            buttonMode = ButtonText.text = "X";
            
        }
        else
        {
            buttonMode = ButtonText.text = "O";
             

        }
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
