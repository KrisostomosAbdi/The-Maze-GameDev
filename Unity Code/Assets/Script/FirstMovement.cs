using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FirstMovement : MonoBehaviour
{
    public Text HitungSkor;
    Vector3 right;
    Vector3 up;
    public Text HPCounter;
    Vector3 down;
    Vector3 left;
    int hp = 100;
    public GameObject MenuDeath;
    float velocity;
    int nilai = 0;
    bool FirstDead = false;
    public GameObject player1;
    bool FirstWin = false;
    private float boosttime;
    private bool boosting;

    // Start is called before the first frame update
    void Start()
    {
        left = new Vector3(-1, 0, 0);
        down = new Vector3(0, -1, 0);
        Time.timeScale = 1;
        MenuDeath.SetActive (false); 
        FirstDead = false;
        FirstWin = false;
        right = new Vector3(1, 0, 0);
        up = new Vector3(0, 1, 0);
        boosting = false;
        boosttime = 0;
        velocity = 2;

    }
    void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.tag == "coin"){
            nilai++;
            FirstSaveHighScore.SaveScore (nilai);
            HitungSkor.text = nilai.ToString() + " POINTS";
            Destroy(collision.gameObject);
        }
        if(collision.gameObject.tag == "bolamusuh"){
            hp -= 20;
            HPCounter.text = "HP="+ hp.ToString();
        }
        if(collision.gameObject.tag == "finish1"){
            win();
        }
        if(collision.gameObject.tag == "potion"){
            hp += 15;   
            Destroy(collision.gameObject);
        }
        if(collision.gameObject.tag == "potion2"){
            hp -= 15;
            Destroy(collision.gameObject);
        }
        if(collision.gameObject.tag == "bom"){
            hp -= 25;
            Destroy(collision.gameObject);
        }
        if(collision.gameObject.tag == "slime"){
            boosting = true;
            velocity = 1;
            Destroy(collision.gameObject);
        }
        if(collision.gameObject.tag == "laser"){
            hp -= 20;
        }
    }
    public bool win(){
        FirstWin = true;
        Destroy(player1);
        WinManager.Win1(FirstWin);
        return FirstWin;
    }
    public bool death(){
        if (hp <= 0 ){
            hp = 0;
            FirstDead = true;
            Destroy(player1);
        }else{
            FirstDead = false;
        }
        DeadManager.Player2(FirstDead);
        return FirstDead;
    }
    // Update is called once per frame
    void Update()
    {
        HPCounter.text = "HP="+ hp.ToString();
        if (hp <= 0 ){
            hp = 0;
            FirstDead = true;
            DeadManager.Player2(FirstDead);
            Destroy(player1);
        }else{
            FirstDead = false;
        }
        if (Input.GetKey(KeyCode.D)){
            transform.position = transform.position + (right * velocity * Time.deltaTime);
        }else if(Input.GetKey(KeyCode.W)){
            transform.position = transform.position + (up * velocity * Time.deltaTime);
        }else if(Input.GetKey(KeyCode.S)){
            transform.position = transform.position + (down * velocity * Time.deltaTime);
        }else if (Input.GetKey(KeyCode.A)){
            transform.position = transform.position + (left * velocity * Time.deltaTime);
        }
        if (boosting){
            boosttime += Time.deltaTime;
            if(boosttime >= 7){
                velocity = 2;
                boosttime = 0;
                boosting = false;
            }
        }
    }
}
