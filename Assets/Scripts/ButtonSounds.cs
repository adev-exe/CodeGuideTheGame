using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonSounds : MonoBehaviour
{
    public Button soundButton;
    private AudioSource buttonAudio;
    // don't need this it seems like
    public AudioClip soundC;
    // int value that is update to determine
    // which button is clicked
    public static int check;
    
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("爆発爆発。かがくせんたいDYNAMAN");
        
        buttonAudio = GetComponent<AudioSource>();   
    }


     IEnumerator ExampleCoroutine()
    {

        //Print the time of when the function is first called.
        Debug.Log("Started Coroutine at timestamp : " + Time.time);

        //play sound when button is clicked
        buttonAudio.PlayOneShot(soundC, 0.6f);

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(0.6f);

        if(check == 1){
            SceneManager.LoadScene("Level 1");
        }

        if(check == 2){
            SceneManager.LoadScene("LevelScreen");
        }

        if(check == 3){
            SceneManager.LoadScene("Options");
        }

        if(check == 4){
            Application.Quit();
        }

        if(check == 5){
            SceneManager.LoadScene("MainMenu");
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
        Debug.Log("start button clicked");
        
        StartCoroutine(ExampleCoroutine());

        check = 4;
        ExampleCoroutine();
    }


    public void BackToMainButtonClicked()
    {
        Debug.Log("start button clicked");
        
        StartCoroutine(ExampleCoroutine());

        check = 5;
        ExampleCoroutine();
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
