using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobileMovement : MonoBehaviour
{
    public float velocity;
    private bool left;
    Vector3 moveleft;
    private bool above;
    Vector3 moveup;
    private bool right;
    Vector3 moveright;
    private bool below;
    Vector3 movedown;

    // Start is called before the first frame update
    void Start()
    {

        moveleft = new Vector3(-1, 0, 0);
        left = false;
        moveup = new Vector3(0, 1, 0);
        above = false;
        moveright = new Vector3(1, 0, 0);
        right = false;
        movedown = new Vector3(0, -1, 0);
        below = false;
    }
    public void aboveDown(){
        above = true;
    }
    public void aboveUp(){
        above = false;
    }
    public void leftDown(){
        left = true;
    }
    public void leftUp(){
        left = false;
    }
    public void belowDown(){
        below = true;
    }
    public void belowUp(){
        below = false;
    }
    public void rightDown(){
        right = true;
    }
    public void rightUp(){
        right = false;
    }
    // Update is called once per frame
    void Update()
    {
        if (left){
            transform.position = transform.position + (moveleft * velocity * Time.deltaTime);
        }else if(above){
            transform.position = transform.position + (moveup * velocity * Time.deltaTime);
        }else if(below){
            transform.position = transform.position + (movedown * velocity * Time.deltaTime);
        }else if(right){
            transform.position = transform.position + (moveright * velocity * Time.deltaTime);
        }else{
            transform.position = transform.position + (movedown * 0 * Time.deltaTime);
        }
    }
}
