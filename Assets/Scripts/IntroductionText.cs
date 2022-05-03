using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;


public class IntroductionText : MonoBehaviour
{
    public TMP_Text textComponent;
    public Button continueBtn;
    public Button prevBtn;

    public string[] introMsg;
    private int index = 0;
    
    void Start()
    {   
        textComponent.text = introMsg[index];
    }

    public void PrevButtonClicked()
    {
        if (index > 0) 
        {   
            index--;  
            textComponent.text = introMsg[index];
        }
    }

    public void NextButtonClicked()
    {
        if (index < (introMsg.Length - 1)) 
         {    
            index++;
            textComponent.text = introMsg[index];
         }
         else{
             ContinueGame();
         }
    }
    
    
    
    public void ContinueGame()
    {
        // Create a temporary reference to the current scene.
        Scene currentScene = SceneManager.GetActiveScene ();
        Debug.Log("current scene : " + currentScene);

        // Retrieve the name of this scene.
        string sceneName = currentScene.name;
        Debug.Log("scene name : " + sceneName);

        if(sceneName == "IntroLesson1"){
            SceneManager.LoadScene("Level 1");
        }

        if(sceneName == "IntroLesson2"){
            SceneManager.LoadScene("Level 2");
        }

        if(sceneName == "IntroLesson3"){
            SceneManager.LoadScene("Level 3");
        }

        if(sceneName == "IntroLesson4"){
            SceneManager.LoadScene("Level 4");
        }
        
         if(sceneName == "IntroLesson5"){
            SceneManager.LoadScene("Final Boss");
        }
    }
        
}
