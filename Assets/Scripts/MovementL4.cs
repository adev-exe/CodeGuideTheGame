using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementL4 : MonoBehaviour
{

  public AudioSource moveAudio;
    
  public AudioClip soundC;
  public GameObject bulletPrefab;
  public int numBullets = 1;
  public float Amphetamine = 2;
  public float shootCoolDown = .5f;
  private Vector2 lookDir = Vector2.up;
  private float shootT = 0;

  public void Shoot()
  {
    // Debug.Log(lookDir);
    if(lookDir.magnitude < .01)
    {
      return;
    }

    for(int i = 0; i < numBullets; i++)
    {
      GameObject go = Instantiate(bulletPrefab, transform.position, transform.rotation);
      Bullet bullet = go.GetComponent<Bullet>();
      bullet.dir = lookDir;
      bullet.delay = i * 1 / 20f;
    }
    // Debug.Log("shoot");
    shootT = shootCoolDown;
  }

  void Update()
  {
    float speed = Amphetamine * Time.deltaTime;
    Vector2 dir = new Vector2();

    bool w, a, s, d;
    w = Input.GetKey(KeyCode.W);
    a = Input.GetKey(KeyCode.A);
    s = Input.GetKey(KeyCode.S);
    d = Input.GetKey(KeyCode.D);

    if(w)
    {
      dir += Vector2.up * speed;
    }

    if(a)
    {
      dir += Vector2.left * speed;
    }

    if(s)
    {
      dir += Vector2.down * speed;
    }

    if(d)
    {
      dir += Vector2.right * speed;
    }

    if(dir != Vector2.zero)
    {
      lookDir = dir.normalized;
    }
    // Debug.Log(lookDir);
    // transform.Translate(dir, Space.World);
    GetComponent<Rigidbody2D>().AddForce(dir * 100);

    if(Input.GetKey(KeyCode.Space))
    {
      if(shootT <= 0)
      {
        
        Shoot();
        moveAudio = GetComponent<AudioSource>();
        if(!moveAudio.isPlaying){
                moveAudio.PlayOneShot(soundC, 0.6f);
          }
      }

      // else
      // {
        // shootT -= Time.deltaTime;
      // }
    }

    shootT -= Time.deltaTime;

    if(shootT < 0)
    {
      shootT = 0;
    }
  }

  void OnCollisionEnter2D(Collision2D collision)
  {
    if (collision.gameObject.tag == "Enemy")
    {
      Vector2 dir = -(collision.gameObject.transform.position - transform.position).normalized;
      GetComponent<Rigidbody2D>().AddForce(dir * 2000);
    }
  }
}
