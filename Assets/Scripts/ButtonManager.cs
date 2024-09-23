using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;



public class ButtonManager : MonoBehaviour
{

    public Text ButtonText;
    public bool isPressed = false;
    /* TODO: 
     * create method to signal a button isPressed and send it to the GameManager
     */

    public ButtonManager(bool isPressed_)
    {
        isPressed = isPressed_;
    }
    
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
