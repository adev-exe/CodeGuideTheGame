using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    

    private void OnTriggerEnter2D(Collider2D collision)
    {

        //If the GameObject's name matches the one you suggest, output this message in the console
        

        Debug.Log("Win");
        // Create a temporary reference to the current scene.
        Scene currentScene = SceneManager.GetActiveScene ();
        Debug.Log("current scene : " + currentScene);

        // Retrieve the name of this scene.
        string sceneName = currentScene.name;
        Debug.Log("scene name : " + sceneName);

        if(sceneName == "Level 1"){
            SceneManager.LoadScene("IntroLesson2"); //level 2s
        }
        else{
            SceneManager.LoadScene("Final Boss");
        }
    }
}
