using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Button = UnityEngine.UIElements.Button;


public class ButtonManager : MonoBehaviour
{
    

    /* TODO: 
     * create method to signal a button isPressed and send it to the GameManager
     * create method to Change button text to "X"
     * create method to Change button text to "O"
     */

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnButtonPressed()
    {
        Debug.Log("button has been pressed");
    }

    public void ChangeText()
    {

    }
    public void ChangeToO()
    {

    }

    /*
     * public void XisPressed()
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
    */
}
