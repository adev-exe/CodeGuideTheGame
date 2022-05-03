using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;


public class KeepAudio : MonoBehaviour
{
    private static KeepAudio _instance;
    
    void Awake()
    {
        // Create a temporary reference to the current scene.
        Scene currentScene = SceneManager.GetActiveScene ();
        Debug.Log("current scene : " + currentScene);

        // Retrieve the name of this scene.
        string sceneName = currentScene.name;
        Debug.Log("scene name : " + sceneName);

        // if there is not an instance yet of this class
        // set the instance to this
        if(!_instance)
        {
            _instance = this;
        }
        // else, if there is already an instance, destroy it
        // so that the audio does not get made again
        else
        {
            Destroy(this.gameObject);
        }
        
        // makes sure that when changing scenes the sound
        // played does not get destroyed
        DontDestroyOnLoad(this.gameObject);
    }
    
}
