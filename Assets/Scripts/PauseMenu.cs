using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;

    //Menus m = new Menus();
    //Menus m = gameObject.AddComponent(typeof(Menus)) as Menus;
    
    // Update is called once per frame
    void Start()
    {
        //Menus m = gameObject.AddComponent(typeof(Menus)) as Menus;
        
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

   
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }


    public void LoadMenu()
    {
        //Menus m = gameObject.AddComponent(typeof(Menus)) as Menus;
        //m.pauseButtonClicked();
        pauseMenuUI.SetActive(false);
       SceneManager.LoadScene("MainMenu");
    }
    

    public void QuitGame()
    {
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif
        Application.Quit();
    }
}
