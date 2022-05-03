using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMan : MonoBehaviour
{

    public float speed;
    public Rigidbody2D rb;
    
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

  //  void OnTriggerEnter2D(Collider2D col)
    //{

        
      //  Destroy(gameObject);
    //}
    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("OnCollisionEnter2D");
        if (col.gameObject.tag == "Enemy")
        {
            Destroy(col.gameObject);
        }
            Destroy(gameObject);
    }



}
