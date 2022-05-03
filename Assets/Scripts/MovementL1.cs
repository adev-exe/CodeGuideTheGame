using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class MovementL1 : MonoBehaviour
{

    public AudioSource moveAudio;
    
    public AudioClip soundC;

    public float Amphetamine = 2;
    public static bool W, A, S, D;

    // Start is called before the first frame update
    void Start()
    {
        moveAudio = GetComponent<AudioSource>();   
    }

    void Update()
    {
        float speed = Amphetamine * Time.deltaTime;
        Vector2 dir = new Vector2();

        if (Input.GetKey(KeyCode.W) && W)
        {
            dir += Vector2.up * speed;
            
            if(!moveAudio.isPlaying){
                moveAudio.PlayOneShot(soundC, 0.6f);
            }
            
        }

        if (Input.GetKey(KeyCode.A) && A)
        {
            dir += Vector2.left * speed;
           
            if(!moveAudio.isPlaying){
                moveAudio.PlayOneShot(soundC, 0.6f);
            }
        }

        if (Input.GetKey(KeyCode.S) && S)
        {
            dir += Vector2.down * speed;
            
            if(!moveAudio.isPlaying){
                moveAudio.PlayOneShot(soundC, 0.6f);
            }
        }

        if (Input.GetKey(KeyCode.D) && D)
        {
            dir += Vector2.right * speed;
            
            if(!moveAudio.isPlaying){
                moveAudio.PlayOneShot(soundC, 0.6f);
            }
        }

        transform.Translate(dir, Space.World);
    }
}
