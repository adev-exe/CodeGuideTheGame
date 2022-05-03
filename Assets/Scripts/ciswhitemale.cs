using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ciswhitemale : MonoBehaviour
{
   public void moveUp()
    {
        Debug.Log("up");
        movement.Amphetamine = 2;
        movement.switchInt = 1;
    }
   public void moveDown()
    {
        Debug.Log("down");
        movement.Amphetamine = 2;
        movement.switchInt = 2;
    }
    public void moveLeft()
    {
        Debug.Log("left");
        movement.Amphetamine = 2;
        movement.switchInt = 3;
    }
    public void moveRight()
    {
        Debug.Log("right");
        movement.Amphetamine = 2;
        movement.switchInt = 4;
    }
}
