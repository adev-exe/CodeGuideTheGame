using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementFinalBossAnim : MonoBehaviour
{
    public AudioSource moveAudio;
    
    public AudioClip soundC;

    public AudioClip fireS;


    public float moveSpeed = 5f;

    public Rigidbody2D rb;
    public Animator anim;
    Vector2 movement;


    private void start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        moveAudio = GetComponent<AudioSource>();
    }

    private void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        anim.SetFloat("Horizontal", movement.x);
        anim.SetFloat("Vertical", movement.y);
        anim.SetFloat("Speed", movement.sqrMagnitude);
        
        if (Input.GetKey(KeyCode.W))
        {   
            if(!moveAudio.isPlaying){
                moveAudio.PlayOneShot(soundC, 0.6f);
            }
            
        }

        if (Input.GetKey(KeyCode.A))
        {
           
            if(!moveAudio.isPlaying){
                moveAudio.PlayOneShot(soundC, 0.6f);
            }
        }

        if (Input.GetKey(KeyCode.S))
        {
            
            if(!moveAudio.isPlaying){
                moveAudio.PlayOneShot(soundC, 0.6f);
            }
        }

        if (Input.GetKey(KeyCode.D))
        {
            
            if(!moveAudio.isPlaying){
                moveAudio.PlayOneShot(soundC, 0.6f);
            }
        }


        if (Input.GetKey("right"))
        {
            
            if(!moveAudio.isPlaying){
                moveAudio.PlayOneShot(fireS, 0.6f);
            }
        }

         if (Input.GetKey("left"))
        {
            
            if(!moveAudio.isPlaying){
                moveAudio.PlayOneShot(fireS, 0.6f);
            }
        }

    }


    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }

}