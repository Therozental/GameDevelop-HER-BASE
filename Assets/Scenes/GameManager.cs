using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using TMPro;
using UnityEngine.UI;



public class GameManager : MonoBehaviour
{

    /* TODO: 
     * create array for the buttons
     * create a method that do something after button is pressed
     * create method to manage the turns of the X/O
     * understand how to manage the win condition??
     */

    [SerializeField]
    int[,] TicTacToeBoard;

    void Start()
    {
        
        
        for (int row = 0; row < 3; row++)
        {
            for (int column = 0; column < 3; column++)
            {

                GameObject(Button)
                TicTacToeBoard[row, column] = button;
               
            }
        }
        
    }

    /*
    void Update() //gameloop
    {
        
    }
    */

    public void SwitchType() //switch between X and O
    {
        
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
