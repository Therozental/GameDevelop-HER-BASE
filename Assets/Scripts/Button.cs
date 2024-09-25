using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using UnityEngine.UIElements;

public class Button : MonoBehaviour
{
    public TextMeshProUGUI ButtonText;
    public bool isPressed = false;
    public GameManager gameManager;
    public string symbol = null;
   
    public void OnButtonClick()
    {
        if(isPressed == true)
        {
            return;
        }
       ChangeText();
       gameManager.SwitchTurns();
       isPressed = true;
       gameManager.CheckWinX();
       gameManager.CheckWinO();
    }

    public void ChangeText()
    {
        if(gameManager.isXTurn() == true)
        {
            ButtonText.text = "X";
            symbol = "X";
        }
        else
        {
            ButtonText.text = "O";
            symbol = "O";
        }
    }
}
