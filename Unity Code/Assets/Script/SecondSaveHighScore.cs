using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SecondSaveHighScore : MonoBehaviour
{
    public Text teksHighScore;
    // Start is called before the first frame update
    void Start(){
        teksHighScore.text = "2ND PLAYER : " + LoadHighScore().ToString();
    }
    public static int LoadHighScore()
    {
        int hg = 0;
        if(!PlayerPrefs.HasKey ("highscore1"))
            PlayerPrefs.SetInt ("highscore1", 0);
        else
            hg = PlayerPrefs.GetInt ("highscore1");
        return hg;
    }
    public static void SaveScore(int score) 
    {
        int hg = 0;
        // hg-=hg;
        // PlayerPrefs.SetInt ("highscore1", hg);
        if (!PlayerPrefs.HasKey ("highscore1"))
            PlayerPrefs.SetInt ("highscore1", 0);
        else{
            hg = PlayerPrefs.GetInt ("highscore1");
            if (score >= hg){
                PlayerPrefs.SetInt ("highscore1", score);
            }else{
            }
        }
    }
}
