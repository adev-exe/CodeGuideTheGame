using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class onMDkill : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Pressed primary button.");
            Destroy(GameObject.FindWithTag("CodeBuddy2"));
            Destroy(GameObject.FindWithTag("CodeBuddy"));
        }
    }
}
