using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SecondMovement : MonoBehaviour
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
    int nilai2 = 0;
    bool SecondDead = false;
    public GameObject player2;
    bool SecondWin = false;
    private float boosttime;
    private bool boosting;
    public GameObject fire;

    // Start is called before the first frame update
    void Start()
    {
        left = new Vector3(-1, 0, 0);
        down = new Vector3(0, -1, 0);
        Time.timeScale = 1;
        MenuDeath.SetActive (false); 
        SecondDead = false;
        right = new Vector3(1, 0, 0);
        up = new Vector3(0, 1, 0);
        boosting = false;
        boosttime = 0;
        velocity = 2;
    }
    void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.tag == "coin"){
            nilai2++;
            SecondSaveHighScore.SaveScore (nilai2);
            HitungSkor.text = nilai2.ToString() + " POINTS";
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
        if(collision.gameObject.tag == "laser"){
            hp -= 20;
        }
        if(collision.gameObject.tag == "slime"){
            boosting = true;
            velocity = 1;
            Destroy(collision.gameObject);
        }
    }

    public bool win(){
        SecondWin = true;
        Destroy(player2);
        WinManager.Win2(SecondWin);
        return SecondWin;
    }
    public bool death(){
        if (hp <= 0 ){
            hp = 0;
            SecondDead = true;
            Destroy(player2);
        }else{
            SecondDead = false;
        }
        DeadManager.Player2(SecondDead);
        return SecondDead;
    }
    // Update is called once per frame
    void Update()
    {
        HPCounter.text = "HP="+ hp.ToString();
        if (hp <= 0 ){
            hp = 0;
            SecondDead = true;
            DeadManager.Player2(SecondDead);
            Destroy(player2);
        }else{
            SecondDead = false;
        }
        if (Input.GetKey("right")){
            transform.position = transform.position + (right * velocity * Time.deltaTime);
        }else if(Input.GetKey("up")){
            transform.position = transform.position + (up * velocity * Time.deltaTime);
        }else if(Input.GetKey("down")){
            transform.position = transform.position + (down * velocity * Time.deltaTime);
        }else if (Input.GetKey("left")){
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
