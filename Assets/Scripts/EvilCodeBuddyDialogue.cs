using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class EvilCodeBuddyDialogue : MonoBehaviour
{
    public NPCConversation myConversation;

    public void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ConversationManager.Instance.StartConversation(myConversation);
        }
    }
}
