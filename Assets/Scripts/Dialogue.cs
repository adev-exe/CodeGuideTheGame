using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.UI;

public class Dialogue : MonoBehaviour
{
    public TMP_Text textComponent;
    public Button nextBtn;
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

  
        else
        {
            Destroy(GameObject.Find("DialogueImage"));
            Destroy(GameObject.Find("CodeBuddyImage"));
            
        }
    }
}
