using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alien : MonoBehaviour
{
  public int health = 10;
  public float regenTime = 1f;
  private bool shouldRegen = false;
  private float regenCountDown = 0;

  public void ApplyDamage(int damage)
  {
    health -= damage;
    if(health <= 0)
    {
      Destroy(this.gameObject);
    }

    shouldRegen = true;
    regenCountDown = regenTime;
  }

  void OnGUI()
  {
    Vector2 targetPos;
    targetPos = Camera.main.WorldToScreenPoint (transform.position);
    GUI.Box(new Rect(targetPos.x - 30, Screen.height - targetPos.y + 15, 60, 20), health + "/" + 10);
  }

  void Update()
  {
    if(shouldRegen)
    {
      regenCountDown -= Time.deltaTime;

      if(regenCountDown <= 0)
      {
        health = 10;
        shouldRegen = false;
      }
    }
  }


    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "bullet")
        {
            //If the GameObject's name matches the one you suggest, output this message in the console
            Debug.Log("Do something here");
        }

        Debug.Log("OnCollisionEnter2D");
    }
}
