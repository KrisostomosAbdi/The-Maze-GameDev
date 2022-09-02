using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadManager : MonoBehaviour
{
    public GameObject MenuDeath;
    public static bool First, Second;
    // Start is called before the first frame update
    void Start()
    {
        First = false;
        Second = false;
        MenuDeath.SetActive (false); 
        DeathChecker();
    }
    public static bool Player1(bool player1){
        First = player1;
        return First;
    }
    public static bool Player2(bool player2){
        Second = player2;
        return Second;
    }
    public void DeathChecker(){
        // FirstMovement first = new FirstMovement();
        // SecondMovement second = new SecondMovement();

        // bool First = Player1();
        // bool Second = Player2();
        if(First && Second == true){
            MenuDeath.SetActive (true); 
            Time.timeScale = 0;
        }else if(First && Second == false){
            MenuDeath.SetActive (false); 
            Time.timeScale = 1;
        }else if(Second == true && First == false){
            MenuDeath.SetActive (true); 
            Time.timeScale = 0; 
        }else if(Second == false && First == true){
            MenuDeath.SetActive (true); 
            Time.timeScale = 0; 
        }
    }
    // Update is called once per frame
    void Update()
    {
        DeathChecker();
    }
}
