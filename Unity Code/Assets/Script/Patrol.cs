using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    public float speed;
    private bool MoveToRight = true;
    public Transform groundDetection;

    void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.tag == "wall"){
            transform.eulerAngles = new Vector3(0, 0, 0);
            MoveToRight = true;
        }
        if(collision.gameObject.tag == "wall2"){
            transform.eulerAngles = new Vector3(0, -180, 0);
            MoveToRight = false;
        }
    }
    void Update(){
        transform.Translate(Vector2.right*speed*Time.deltaTime);
        RaycastHit2D groundInfo = Physics2D.Raycast(groundDetection.position, Vector2.down, 9f);
        if(groundInfo.collider == false){
            if(MoveToRight == true){
                transform.eulerAngles = new Vector3(0, -180, 0);
                MoveToRight = false;
            }else{
                transform.eulerAngles = new Vector3(0, 0, 0);
                MoveToRight = true;
            }
        }
    }
}
