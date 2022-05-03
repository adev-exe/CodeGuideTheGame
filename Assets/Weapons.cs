using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapons : MonoBehaviour
{
   public Transform firePointR; 
    public Transform firePointL; 
  
   
    public GameObject bulletprefab;
    public GameObject bulletprefabL;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("right"))
        {
            ShootR();
        }
        else if (Input.GetKey("left"))
        {
            ShootL();
        }
       
    }

    void ShootR ()
    {
        Instantiate(bulletprefab, firePointR.position, firePointR.rotation);
    }

    void ShootL()
    {
        Instantiate(bulletprefabL, firePointL.position, firePointL.rotation);
    }
}
