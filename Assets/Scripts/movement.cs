using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public static float Amphetamine = 0;
    public static float switchInt = 0;
    public Rigidbody2D rb;

    // Update is called once per frame
    void Update()
    {
        switch (switchInt)
        {
            // Space.World keeps movement relative to world coordinates
            case 1:
                transform.Translate(Vector2.up * Amphetamine * Time.deltaTime, Space.World);
                break;
            case 2:
                transform.Translate(Vector2.down * Amphetamine * Time.deltaTime, Space.World);
                break;
            case 3:
                transform.Translate(Vector2.left * Amphetamine * Time.deltaTime, Space.World);
                break;
            case 4:
                transform.Translate(Vector2.right * Amphetamine * Time.deltaTime, Space.World);
                break;
        }
    }
}
