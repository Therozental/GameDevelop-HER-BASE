using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class GameManager : MonoBehaviour
{

    /* TODO: 
     * create array for the buttons
     * create a method that do something after button is pressed
     * create method to manage the turns of the X/O
     * understand how to manage the win condition??
     */
    int row = 0;
    int column = 0;
    [SerializeField]
    ButtonManager[,] TicTacToeBoard;

    void Start()
    {
      
        //  GameObject(Button);
        //  TicTacToeBoard[row, column] = button;
    }


    void Update() 
    {
      
    }
    

    public void SwitchTurn(ButtonManager.ButtonText) //switch between X and O
    {

        for (int row = 0; row < 3; row++)
        {
            for (int col = 0; col < 3; col++)
            {
                TicTacToeBoard[row, col] = (row + col) % 2 == 0 ? ButtonText.text = "X" : "o";
            }
            //  if(isPressed == true)
            {
            
        }
    }


    /*
    void WinCondition(Button )
    {
    one of these condition happen:

    get all X or O buttons types:

        if buttonType [row] = 1,2,3
        if buttonType [row] = 4,5,6
        if buttonType [row] = 7,8,9

        if buttonType [column] = 1,4,7
        if buttonType [column] = 2,5,8
        if buttonType [column] = 3,6,9

        if buttonType [row],[column] = 1,5,9
        if buttonType [row],[column] = 3,5,7
        if buttonType [row],[column] = 9,5,1
        if buttonType [row],[column] = 7,5,3

    you win!

    }
    */




}
