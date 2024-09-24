using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Unity.VisualScripting;

public class GameManager : MonoBehaviour
{
    /* TODO: 
     * create array for the buttons
     * create a method that do something after button is pressed
     * create method to manage the turns of the X/O
     * understand how to manage the win condition??
     */

    // [SerializeField] GameObject[,] TicTacToeBoard = new GameObject[3,3];

    //GameObject[,] ButtonLis = new GameObject[3,3];
    // [SerializeField] List<GameObject> ButtonList = new List<GameObject>();

    bool XTurn = true;
    GameObject WinMessage;
    
    [SerializeField] Button[,] TicTacToeBoard = new Button[3, 3];  // 2D array for buttons
    [SerializeField] Button[] buttonList;

    void Start()
    {
        int index = 0;

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                
                TicTacToeBoard[i, j] = buttonList[index];
                Debug.Log($"button{buttonList[index]} position is on {TicTacToeBoard[i, j]}");
                index++;
            }
        }
    }

    void Update()
    {
        
    }

   public bool isXTurn()
   {
        if(!XTurn) // if it's not x turn
        {
            return false;
        }
        return true; // if it is x turn
   }


    public void SwitchTurns() //switch between X and O
    {
            XTurn = !XTurn;


    }

    void isThereAWin()
    {
        //loop of get buttonmode
      if (buttonList[0] == buttonList[1] == buttonList[2])
        {
            WinMessage.SetActive(true);
        }
    }
}

        //for (int row = 0; row < 3; row++)
        //{
        //    for (int col = 0; col < 3; col++)
        //    {
        //   TicTacToeBoard[row, col] = (row + col) % 2 == 0 ? button.ChangeToX() : button.ChangeToO();
        //    }
        //    //  if(isPressed == true)
        //    {

        //    }
        //}
/*
void WinCondition(Button )
{
one of these condition happen:

get all X or O buttons types:

if b1 && b2 && b3 == 1/"X" -> win condition

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

