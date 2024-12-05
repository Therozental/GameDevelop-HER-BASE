using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Unity.VisualScripting;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int number = 7;
        string Color = "";

        PrintResult(number);
        PrintIf(number);
        CatType(Color);
        
    }

    void PrintResult(int number)
    {
        Debug.Log(number);
    }

    void PrintIf(int number)
    {
        if(number >= 7)
        {
            Debug.Log($"wow your number of cats is bigger than {number}, congrats");
        }
        else
        {
            Debug.Log($"oh your number of cats is smaller than {number}, that's a bummer");
        }
    }
//great
    private void CatType(string Color)
    {
        switch(Color)
        {
            case "black":
                Debug.Log("you got a black cat!");
                break;

            case "ginger":
                Debug.Log("you got a ginger cat!");
                break;

            case "white":
                Debug.Log("you got a white cat!");
                break;

            default:
                Debug.Log("you got a lot of cats!");
                break;

        }
    }

}
