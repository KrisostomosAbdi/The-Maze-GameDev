using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour
{
    public static MusicController musikku = null;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public MusicController Instance(){
        return musikku;
    }

    public void Awake(){
        if(musikku != null && musikku != this){
            Destroy(this.gameObject);
            return;
        } else {
            musikku = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }
}
