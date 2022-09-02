using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torch : MonoBehaviour
{
     public float flareOnTime = 2;
     public float flareOffTime = 20;
    GameObject[] obor;
    // Start is called before the first frame update
    void Start()
    {
        obor = GameObject.FindGameObjectsWithTag("torch");
        StartCoroutine("BlinkFlare");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator BlinkFlare() {

    while (true) {
        yield return new WaitForSeconds (flareOnTime);
        foreach (GameObject obr in obor){
        obr.SetActive(false);
        }
        yield return new WaitForSeconds (flareOffTime);
        foreach (GameObject obr in obor){
        obr.SetActive(true);
        }
    }
}
}
