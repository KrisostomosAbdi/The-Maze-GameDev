using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    float flareOnTime = 2;
    float flareOffTime = 1;
    GameObject[] laserku;
    // Start is called before the first frame update
    void Start()
    {
        laserku = GameObject.FindGameObjectsWithTag("laser");
        StartCoroutine("BlinkFlare");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator BlinkFlare() {

    while (true) {
        yield return new WaitForSeconds (flareOnTime);
        foreach (GameObject lsr in laserku){
        lsr.SetActive(false);
        }
        yield return new WaitForSeconds (flareOffTime);
        foreach (GameObject lsr in laserku){
        lsr.SetActive(true);
        }
    }
}
}
