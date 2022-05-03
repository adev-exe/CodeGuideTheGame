using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
  public float delay;
  public Vector2 dir;
  public float speed;

  void Update()
  {
    delay -= Time.deltaTime;
    if(delay > 0)
    {
      return;
    }
    // Debug.Log(dir);
    transform.position += new Vector3(dir.x, dir.y, 0) * speed * Time.deltaTime;
  }

  void OnCollisionEnter2D(Collision2D collision)
  {
    Debug.Log(collision.gameObject.name);
    if (collision.gameObject.tag == "Enemy")
    {
      collision.gameObject.SendMessage("ApplyDamage", 1);
    }
    Destroy(this.gameObject);
  }
}
