using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ButtonText : MonoBehaviour
{
    public TMP_Text buttonText;
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
