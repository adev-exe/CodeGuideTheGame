using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using TMPro;

public class SettingsScript : MonoBehaviour
{
    public AudioMixer audioMixer;

    // reference to resolution dropdown
    public TMP_Dropdown resolutionDropdown;

    Resolution[] resolutions;

    void Start ()
    {
        // get an array of all resolutions
        resolutions = Screen.resolutions;

        // clear resolution dropdown list
        resolutionDropdown.ClearOptions();

        // list of resolutions in string
        List<string> optionsList = new List<string>();

        // variable used to set current resolution
        int currentResolutionIndex = 0;

        // add each resolution to optionsList
        for (int i = 0; i < resolutions.Length; i++)
        {
            // string that will display the resolution
            string option = resolutions[i].width + " x " + resolutions[i].height;
            optionsList.Add(option);

            // if the resolution that is taken from the array of
            // resolutions is the current resolution of the user's
            // screen then hold that resolution value
            if (resolutions[i].width == Screen.currentResolution.width &&
                resolutions[i].height == Screen.currentResolution.height)
            {
                currentResolutionIndex = i;
            }
        }

        // add resolutions to the resolution dropdown
        resolutionDropdown.AddOptions(optionsList);

        // set the resolution to the current resolution 
        // of user's screen
        resolutionDropdown.value = currentResolutionIndex;
        resolutionDropdown.RefreshShownValue();
    }


    public void SetResolution (int resolutionIndex)
    {
        // used to get a reference to the current 
        //resolutions' width and height values
        Resolution resolution = resolutions[resolutionIndex];

        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }

    public void SetVolume (float volume)
    {
        // uses Unity to automatically set the volume
        // of the auido mixer by using the slider
        // in the settins menu
        audioMixer.SetFloat("volume", volume);
        Debug.Log("volume level " + volume);
    }

    public void SetQuality(int qualityIndex)
    {
        // using QualitySettings.Set... allows for quality
        // to be set by Unity automatically for the index
        // chosen
        QualitySettings.SetQualityLevel(qualityIndex);
    }

    public void SetFullscreen (bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }
}
