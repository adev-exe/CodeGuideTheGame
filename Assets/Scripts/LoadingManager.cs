using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingManager : MonoBehaviour
{
    // public Vector2 level1Pos, level2Pos, level3Pos, level4Pos, level5Pos
    static int level;
    public List<GameObject> positions;
    public List<string> scenes;
    public GameObject playerSprite;
    public float speed = 1;
    float t;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        int ai = level > 0 ? level - 1 : 0;
        Vector2 a = positions[ai].transform.position;
        Vector2 b = positions[level].transform.position;
        float t2 = t * speed;
        playerSprite.transform.position = a + (b - a) * Mathf.Min(t2, 1);

        if (t2 > 1.5)
        {
            SceneManager.LoadScene(scenes[level]);
        }
    }

    public static void GoToLevel(int _level)
    {
        level = _level;
        SceneManager.LoadScene("Scenes/Loading Screen");
    }
}
