using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveHighScore : MonoBehaviour
{
    public Text teksHighScore;
    // Start is called before the first frame update
    void Start(){
        teksHighScore.text = "HIGHSCORE : " + LoadHighScore().ToString();
    }
    public static int LoadHighScore()
    {
        int hg = 0;
        if(!PlayerPrefs.HasKey ("highscore"))
            PlayerPrefs.SetInt ("highscore", 0);
        else
            hg = PlayerPrefs.GetInt ("highscore");
        return hg;
    }
    public static void SaveScore(int score) 
    {
        int hg = 0;
        // hg-=hg;
        // PlayerPrefs.SetInt ("highscore", hg);
        if (!PlayerPrefs.HasKey ("highscore"))
            PlayerPrefs.SetInt ("highscore", 0);
        else{
            hg = PlayerPrefs.GetInt ("highscore");
            if (score >= hg){
                PlayerPrefs.SetInt ("highscore", score);
            }else{
            }
        }
    }
}
