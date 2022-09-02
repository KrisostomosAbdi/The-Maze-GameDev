using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacle : MonoBehaviour
{
    public GameObject obj;
    public static bool canBlink = true;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine( ShowAndHide(obj, 1.5f) );
    }
       IEnumerator ShowAndHide( GameObject go, float delay )
       {

            go.SetActive(true);
            yield return new WaitForSeconds(delay);
            go.SetActive(false);

       }
    // Update is called once per frame
    void LateUpdate()
    {
    }
}
