using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerL3 : MonoBehaviour
{
  public List<DroppableL3> locations;
  private Vector2 startPos;
  private float t;
  private bool active;
  private int curLocation;
  public float speed;

  public void Go()
  {
    if (active)
    {
      return;
    }

    curLocation = -1;
    active = true;
    t = 0;
  }

  public void Reset()
  {
    curLocation = -1;
    active = false;
    t = 0;
    this.transform.position = startPos;
  }

  void Start()
  {
    startPos = this.transform.position;
  }

  void Update()
  {
    if (!active)
    {
      return;
    }
    Debug.Log("a");
    Vector2 start = curLocation < 0 ? startPos : (Vector2) (locations[curLocation].transform.position);
    Debug.Log("b");
    Vector2 target = (locations[curLocation + 1].transform.position);
    Debug.Log("c");
    // Vector2 start = curLocation < 0 ? startPos : getAnchoredPos(locations[curLocation]);
    // Vector2 target = getAnchoredPos(locations[curLocation + 1]);
    t += Time.deltaTime;
    Vector2 a = start - new Vector2(0, 0);
    Vector2 b = target - new Vector2(0, 0);
    float t2 = t * speed;
    this.transform.position = a + (b - a) * Mathf.Min(t2, 1);
    // Debug.Log(this.transform.position);
    if (t2 > 1.5)
    {
      if (locations[curLocation + 1].draggable != null)
      {
        Debug.Log("d");
        curLocation++;
        Debug.Log(curLocation);
        t = 0;
        if (curLocation + 1 >= locations.Count)
        {
          Debug.Log("YOU WIN!");
          Hints.ShowHints();
          Reset();
        }
      }
      else
      {
        Debug.Log("LOSER!");
        Reset();
      }
    }
  }

  Vector2 getAnchoredPos(DroppableL3 o)
  {
    var rect = o.gameObject.GetComponent<RectTransform>();
    return rect.anchoredPosition;
  }
}
