using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;

public class LevelManager : MonoBehaviour
{
    public Button Level1, Level2, Level3;

    public static int LoadLevel(){
        int hg = 0;
        if (!PlayerPrefs.HasKey ("btnlevel"))
            PlayerPrefs.SetInt ("btnlevel", 0);
        else
            // PlayerPrefs.SetInt ("btnlevel", 0);
            hg = PlayerPrefs.GetInt ("btnlevel");
        return hg;
    }
    public static void saveLevel(int lvl){
        if (!PlayerPrefs.HasKey ("btnlevel"))
            PlayerPrefs.SetInt ("btnlevel", 0);
        else
            // PlayerPrefs.SetInt ("btnlevel", 0);
            PlayerPrefs.SetInt ("btnlevel", lvl);
    }
    void LoadButton(){
        Level1 = GameObject.Find ("Easy").GetComponent<Button>();
        Level2 = GameObject.Find ("Medium").GetComponent<Button>();
        Level3 = GameObject.Find ("Hard").GetComponent<Button>();
        Level1.interactable = Level2.interactable = Level3.interactable = false;
    }
    // Start is called before the first frame update
    void Start()
    {
        try{
            LoadButton();
            int Levelstate = LoadLevel();
            switch (Levelstate){
                case 0:
                    Level1.interactable = true;
                    break;
                case 1:
                    Level1.interactable = true;
                    Level2.interactable = true;
                    break;
                case 2:
                    Level1.interactable = true;
                    Level2.interactable = true;
                    Level3.interactable = true;
                    break;
            }
        }
            catch(NullReferenceException e){
        }
    }

    // Update is called once per frame
    void Update()
    {
    if (Application.platform == RuntimePlatform.Android) {
        if (Input.GetKeyUp (KeyCode.Escape)) {
            Application.Quit ();
            return;
            }
        }
    }
}
