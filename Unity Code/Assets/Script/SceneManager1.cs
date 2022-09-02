using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager1 : MonoBehaviour
{
    public void BackMenu()
    {
        SceneManager.LoadScene ("MainMenu");
    }  
    public void NewScene()
    {   
        SceneManager.LoadScene ("New");
    }
    public void ChooseMode()
    {
        SceneManager.LoadScene ("GameModeChooser");
    } 
    public void SingleChooseLevel()
    {
        SceneManager.LoadScene ("SingleLevelChooser");
    } 
    public void MultiChooseLevel()
    {
        SceneManager.LoadScene ("MultiLevelChooser");
    } 
    public void LoadLvl1()
    {
        SceneManager.LoadScene ("Level1");
    }
    public void LoadLvl2()
    {
        SceneManager.LoadScene ("Level2");
    }
    public void LoadLvl3()
    {
        SceneManager.LoadScene ("Level3");
    }
    public void MultiLoadLvl1()
    {
        SceneManager.LoadScene ("2Level1");
    }
    public void MultiLoadLvl2()
    {
        SceneManager.LoadScene ("2Level2");
    }
    public void MultiLoadLvl3()
    {
        SceneManager.LoadScene ("2Level3");
    }
    public void repeat(){
        Scene scene = SceneManager.GetActiveScene(); 
        SceneManager.LoadScene(scene.name);
    }
    public void HelpMenu()
    {
        SceneManager.LoadScene ("Help");
    }  
    public void Credit()
    {
        SceneManager.LoadScene ("CreditMenu");
    }  
    public void Exit()
    {
        Application.Quit();
    }    

    // Start is called before the first frame update
    void Start()
    {
        
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
