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
    // [SerializeField] List<GameObject> button = new List<GameObject>();

    bool XTurn = true;
    public GameObject X_WINS;
    public GameObject O_WINS;

    [SerializeField] Button[,] TicTacToeBoard = new Button[3, 3];  // 2D array for buttons
    [SerializeField] Button[] button;

    void Start()
    {
        int index = 0;

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {

                TicTacToeBoard[i, j] = button[index];
                Debug.Log($"button{button[index]} position is on {TicTacToeBoard[i, j]}");
                index++;
            }
        }
    }

    public bool isXTurn()
    {
        if (!XTurn) // if it's not x turn
        {
            return false;
        }
        return true; // if it is x turn
    }

    public void SwitchTurns() //switch between X and O
    {
        XTurn = !XTurn;
    }

    public void CheckWinX()
    {
        //columns
        if ((button[0].symbol == "X") && (button[1].symbol == "X") && (button[2].symbol == "X"))
        {
            X_WINS.SetActive(true);
        }
        if ((button[3].symbol == "X") && (button[4].symbol == "X") && (button[5].symbol == "X"))
        {
            X_WINS.SetActive(true);
        }
        if ((button[6].symbol == "X") && (button[7].symbol == "X") && (button[8].symbol == "X"))
        {
            X_WINS.SetActive(true);
        }
        //rows:
        if ((button[0].symbol == "X") && (button[3].symbol == "X") && (button[6].symbol == "X"))
        {
            X_WINS.SetActive(true);
        }
        if ((button[1].symbol == "X") && (button[4].symbol == "X") && (button[7].symbol == "X"))
        {
            X_WINS.SetActive(true);
        }
        if ((button[2].symbol == "X") && (button[5].symbol == "X") && (button[8].symbol == "X"))
        {
            X_WINS.SetActive(true);
        }
        // diagonal
        if ((button[0].symbol == "X") && (button[4].symbol == "X") && (button[8].symbol == "X"))
        {
            X_WINS.SetActive(true);
        }
        if ((button[2].symbol == "X") && (button[4].symbol == "X") && (button[6].symbol == "X"))
        {
            X_WINS.SetActive(true);
        }
        return;
    }

    public void CheckWinO()
    {
        //columns
        if ((button[0].symbol == "O") && (button[1].symbol == "O") && (button[2].symbol == "O"))
        {
            O_WINS.SetActive(true);
        }
        if ((button[3].symbol == "O") && (button[4].symbol == "O") && (button[5].symbol == "O"))
        {
            O_WINS.SetActive(true);
        }
        if ((button[6].symbol == "O") && (button[7].symbol == "O") && (button[8].symbol == "O"))
        {
            O_WINS.SetActive(true);
        }
        //rows:
        if ((button[0].symbol == "O") && (button[3].symbol == "O") && (button[6].symbol == "O"))
        {
            O_WINS.SetActive(true);
        }
        if ((button[1].symbol == "O") && (button[4].symbol == "O") && (button[7].symbol == "O"))
        {
            O_WINS.SetActive(true);
        }
        if ((button[2].symbol == "O") && (button[5].symbol == "O") && (button[8].symbol == "O"))
        {
            O_WINS.SetActive(true);
        }
        // diagonal
        if ((button[0].symbol == "O") && (button[4].symbol == "O") && (button[8].symbol == "O"))
        {
            O_WINS.SetActive(true);
        }
        if ((button[2].symbol == "O") && (button[4].symbol == "O") && (button[6].symbol == "O"))
        {
            O_WINS.SetActive(true);
        }
        return;
    }
}
    /*
void WinCondition(Button )
{
one of these condition happen:

get all X or O buttons types:

if b1 && b2 && b3 == 1/"O" -> win condition

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

