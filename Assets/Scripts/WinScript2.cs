using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class WinScript2 : MonoBehaviour
{
    private int pointsToWin;
    public GameObject Ans;
    int currentPoints;
    
    // Start is called before the first frame update
    void Start()
    {
        pointsToWin = Ans.transform.childCount;
    }

    // Update is called once per frame
    void Update()
    {
        if(currentPoints >= pointsToWin)
        {
            //win
            Debug.Log("winner");
            destroycages();
        }
    }
    public void addPoints()
    {
        currentPoints++;
    }

    public void destroycages()
    {
        Destroy(GameObject.FindWithTag("Cages"));
        StartCoroutine(ExampleCoroutine());

        
    }

    IEnumerator ExampleCoroutine()
    {
        //Print the time of when the function is first called.
        Debug.Log("start timer");

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(5);

        //After we have waited 5 seconds print the time again.
        Debug.Log("end timer");
        SceneManager.LoadScene("IntroLesson3"); //main menu
    }
}
