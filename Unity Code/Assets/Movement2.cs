using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Movement2 : MonoBehaviour
{
    public Text HitungSkor;
    Vector3 right;
    Vector3 up;
    public Text HPCounter;
    Vector3 down;
    Vector3 left;
    int hp = 100;
    public GameObject MenuDeath;
    float velocity = 3;
    int nilai = 0;

    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.GetComponent<Renderer>().enabled = false;
        if (Input.GetKey("right")){
            this.gameObject.GetComponent<Renderer>().enabled = true;
        }else if(Input.GetKey("up")){
            this.gameObject.GetComponent<Renderer>().enabled = true;
        }else if(Input.GetKey("down")){
            this.gameObject.GetComponent<Renderer>().enabled = true;
        }else if (Input.GetKey("left")){
            this.gameObject.GetComponent<Renderer>().enabled = true;

        }
        left = new Vector3(-1, 0, 0);
        down = new Vector3(0, -1, 0);
        Time.timeScale = 1;
        MenuDeath.SetActive (false); 
        right = new Vector3(1, 0, 0);
        up = new Vector3(0, 1, 0);
    }
    void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.tag == "coin"){
            nilai++;
            HitungSkor.text = nilai.ToString() + " POINTS";
            Destroy(collision.gameObject);
        }
        if(collision.gameObject.tag == "bolamusuh"){
            hp -= 20;
            HPCounter.text = "HP = "+ hp.ToString();
        }
        if(collision.gameObject.tag == "finish2"){
            SceneManager.LoadScene("FinishMenu2");
        }
        if(collision.gameObject.tag == "finish1"){
            SceneManager.LoadScene("FinishMenu2");
        }
        if(collision.gameObject.tag == "potion"){
            hp += 15;   
            Destroy(collision.gameObject);
        }
        if(collision.gameObject.tag == "potion2"){
            hp -= 15;
            Destroy(collision.gameObject);
        }
    }
    public void death(){
        MenuDeath.SetActive (true); 
        Debug.Log("Game Over");
        Time.timeScale = 0;
    }
    // Update is called once per frame
    void Update()
    {
        HPCounter.text = "HP = "+ hp.ToString();
        if (hp <= 0 ){
            hp = 0;
            death();
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
    }
}
