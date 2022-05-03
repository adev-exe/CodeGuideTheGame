using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvilRobot : MonoBehaviour
{
    public int health = 5;
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
        GUI.Box(new Rect(targetPos.x - 30, Screen.height - targetPos.y + 15, 60, 20), health + "/" + 5);
    }
    
    void Update()
    {
        if(shouldRegen)
        {
            regenCountDown -= Time.deltaTime;
            
            if(regenCountDown <= 0)
            {
                health = 5;
                shouldRegen = false;
            }
        }
    }
}
