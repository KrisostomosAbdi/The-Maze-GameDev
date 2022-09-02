using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinManager : MonoBehaviour
{
    public static bool FirstWin, SecondWin;

    // Start is called before the first frame update
    void Start()
    {
        FirstWin = false;
        SecondWin = false;
        WinChecker();
    }
    public static bool Win1(bool player1){
        FirstWin = player1;
        return FirstWin;
    }
    public static bool Win2(bool player2){
        SecondWin = player2;
        return SecondWin;
    }
    public void WinChecker(){
        // FirstMovement first = new FirstMovement();
        // SecondMovement second = new SecondMovement();

        // bool First = Player1();
        // bool Second = Player2();
        if(FirstWin && SecondWin == true){
            SceneManager.LoadScene("FinishMenu2");
        }
    }
    // Update is called once per frame
    void Update()
    {
        WinChecker();
    }
}
