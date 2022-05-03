using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Hints : MonoBehaviour
{
    public TMP_Text textComponent;
    public Button continueBtn;
    public string[] introMsg;
    private int index = 0;
    
    public static GameObject codeBuddy;
    public static bool show;
    
    void Start()
    {   
        codeBuddy = GameObject.Find("DialogueImageHints");
        textComponent.text = introMsg[index];
        show = false;
        codeBuddy.SetActive(false);
        // codeBuddy.SetActive(true);
    }
  
    // public void Update()
    // { 
    //     if(show == true)
    //     {
    //         codeBuddy.SetActive(true);
    //     }
    // }
    
    // public static void setFalse(){
    //     show = false;
    // }

    public static void ShowHints()
    {
        codeBuddy.SetActive(true);
    }
    
    // public static void CheckQuestion()
    // { 
    //     if(show == true)
    //     {
    //         codeBuddy.SetActive(true);
    //     }
    //     // else{ ContinueGame()}
    // }
    
    public void ContinueGame()
    {
        Debug.Log("inside Continue Game");
        // Create a temporary reference to the current scene.
        Scene currentScene = SceneManager.GetActiveScene ();
        Debug.Log("current scene : " + currentScene);

        // Retrieve the name of this scene.
        string sceneName = currentScene.name;
        Debug.Log("scene name : " + sceneName);

        if(sceneName == "Level 3"){
            SceneManager.LoadScene("IntroLesson4"); //level 4s
        }
        codeBuddy.SetActive(false);
    }
        
}
