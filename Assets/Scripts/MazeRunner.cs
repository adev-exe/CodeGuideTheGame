using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.UI;

public class MazeRunner : MonoBehaviour
{

    public Button upButton;
    public Button downButton;
    public Button rightButton;
    public Button leftButton;

    public static float Amphetamine = 2;
    public static bool W, A, S, D;

   //float speed = Amphetamine * Time.deltaTime;
   //public static Vector2 dir = new Vector2();

//     void Start()
//     {
//     float speed = Amphetamine * Time.deltaTime;
// Vector2 dir = new Vector2();

   
//     }

    public void moveUp()
    {
       W = true;
       Debug.Log("UP");
        D = false;
        A = false;
        S = false;
    }
     public  void moveDown()
    {
        S = true;
        Debug.Log("Down");
        W = false;
        D = false;
        A = false;
       
    }
    
      void moveLeft()
    {
        A= true;
        W = false;
        D = false;
        S = false;

    }
    
      void moveRight()
    {
        D = true;
        W = false;
        A = false;
        S = false;
    }

    void OnCollisionEnter(Collision collision) 
    {
        W = false;
        D = false;
        A = false;
        S = false;
    }
    
 void Update()
    {
        float speed = Amphetamine * Time.deltaTime;
        Vector2 dir = new Vector2();


        if ( W == true) 
        {
            dir += Vector2.up * speed;
        }

        else if ( A == true) 
        {
            dir += Vector2.left * speed;
        }

        else if ( S == true)
        {
            dir += Vector2.down * speed;
            //  S = false;
          
        }

        else if (D == true)
        {
            dir += Vector2.right * speed;
         
        }

        transform.Translate(dir, Space.World);
    }
}
