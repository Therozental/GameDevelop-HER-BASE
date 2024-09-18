using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tiktaktoe : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string[,] TicTakToeBoard = new string[3, 3];
        string middle = TicTakToeBoard[1, 1];
        for (int row = 0; row < 3; row++)
        {
            for (int col = 0; col < 3; col++)
            {
                TicTakToeBoard[row, col] =  (row + col) % 2 == 0 ? "x" : "o";
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
