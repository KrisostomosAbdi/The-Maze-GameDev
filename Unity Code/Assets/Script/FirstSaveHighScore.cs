using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FirstSaveHighScore : MonoBehaviour
{
    public Text teksHighScore;
    // Start is called before the first frame update
    void Start(){
        teksHighScore.text = "1ST PLAYER : " + LoadHighScore().ToString();
    }
    public static int LoadHighScore()
    {
        int hg = 0;
        if(!PlayerPrefs.HasKey ("highscore0"))
            PlayerPrefs.SetInt ("highscore0", 0);
        else
            hg = PlayerPrefs.GetInt ("highscore0");
        return hg;
    }
    public static void SaveScore(int score) 
    {
        int hg = 0;
        // hg-=hg;
        // PlayerPrefs.SetInt ("highscore0", hg);
        if (!PlayerPrefs.HasKey ("highscore0"))
            PlayerPrefs.SetInt ("highscore0", 0);
        else{
            hg = PlayerPrefs.GetInt ("highscore0");
            if (score >= hg){
                PlayerPrefs.SetInt ("highscore0", score);
            }else{
            }
        }
    }
}
