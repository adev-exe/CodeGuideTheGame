using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Menus : MonoBehaviour
{
    public Button soundButton;
    
    public AudioSource buttonAudio;
    
    // don't need this it seems like
    public AudioClip soundC;
    
    // int value that is update to determine
    // which button is clicked
    public static int check;

    
    // Start is called before the first frame update
    void Start()
    {
        buttonAudio = GetComponent<AudioSource>();   
    }


     IEnumerator ExampleCoroutine()
    {

        //Print the time of when the function is first called.
        Debug.Log("Started Coroutine at timestamp : " + Time.time);

        //play sound when button is clicked
        buttonAudio.PlayOneShot(soundC, 0.8f);

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(0.6f);

        if(check == 1){
            SceneManager.LoadScene("IntroLesson1");
            Debug.Log("check value : " + check);
        }

        if(check == 2){
            SceneManager.LoadScene("LevelScreen");
            Debug.Log("check value : " + check);
        }

        if(check == 3){
            SceneManager.LoadScene("Options");
            Debug.Log("check value : " + check);
        }

        if(check == 4){
            Application.Quit();
        }

        if(check == 5){
            SceneManager.LoadScene("MainMenu");
            Debug.Log("check value : " + check);
        }

        if(check == 6){
            SceneManager.LoadScene("IntroLesson2");
            Debug.Log("check value : " + check);
        }

        if(check == 7){
            SceneManager.LoadScene("IntroLesson3");
            Debug.Log("check value : " + check);
        }

        if(check == 8){
            SceneManager.LoadScene("IntroLesson4");
            Debug.Log("check value : " + check);
        }

        if(check == 9){
            SceneManager.LoadScene("Final Boss");
            Debug.Log("check value : " + check);
        }

        if(check == 10){
            SceneManager.LoadScene("IntroLesson1");
            Debug.Log("check value : " + check);
        }

        //SceneManager.LoadScene(2);

        //After we have waited 5 seconds print the time again.
        Debug.Log("Finished Coroutine at timestamp : " + Time.time);
    }

    public void OptionButtonClicked()
    {
        Debug.Log("option button clicked");
        
        StartCoroutine(ExampleCoroutine());

        check = 3;
        Debug.Log("check value : " + check);
        ExampleCoroutine();
    }

    public void LevelsButtonClicked()
    {
        Debug.Log("level button clicked");
        
        StartCoroutine(ExampleCoroutine());

        check = 2;
        ExampleCoroutine();
    }


    public void StartButtonClicked()
    {
        Debug.Log("start button clicked");
        
        StartCoroutine(ExampleCoroutine());

        check = 1;
        ExampleCoroutine();
    }


    public void QuitButtonClicked()
    {
        Debug.Log("quit button clicked");
        
        StartCoroutine(ExampleCoroutine());

        check = 4;
        ExampleCoroutine();
    }


    public void BackToMainButtonClicked()
    {
        Debug.Log("back button clicked");
        
        StartCoroutine(ExampleCoroutine());

        check = 5;
        Debug.Log("check value : " + check);
        buttonAudio = GetComponent<AudioSource>();
        ExampleCoroutine();
    }


    public void Level1ButtonClicked()
    {
        Debug.Log("level 1 button clicked");
        
        StartCoroutine(ExampleCoroutine());

        check = 10;
        ExampleCoroutine();
    }


    public void Level2ButtonClicked()
    {
        Debug.Log("level 2 button clicked");
        
        StartCoroutine(ExampleCoroutine());

        check = 6;
        ExampleCoroutine();
    }


    public void Level3ButtonClicked()
    {
        Debug.Log("level 3 button clicked");
        
        StartCoroutine(ExampleCoroutine());

        check = 7;
        ExampleCoroutine();
    }


    public void Level4ButtonClicked()
    {
        Debug.Log("level 4 button clicked");
        
        StartCoroutine(ExampleCoroutine());

        check = 8;
        ExampleCoroutine();
    }


    public void FinalBossButtonClicked()
    {
        Debug.Log("final boss button clicked");
        
        StartCoroutine(ExampleCoroutine());

        check = 9;
        ExampleCoroutine();
    }

    public void pauseButtonClicked()
    {
        Debug.Log("pause button clicked");
        SceneManager.LoadScene("MainMenu");
        Debug.Log("check value(before) : " + check);
        
        check = 5;
        Debug.Log("check value(after) : " + check);
        //StartCoroutine(ExampleCoroutine());

        //check = 10;
        //ExampleCoroutine();
    }



}
