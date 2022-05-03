using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragAndDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
  [SerializeField] private Canvas canvas;
  private RectTransform rectTransform;
  public GameObject target;
  public string key;
  private bool dropped;
  private Vector2 startPos;

  private void Awake()
  {
    startPos = transform.position;
    rectTransform = GetComponent<RectTransform>();
  }

  public void OnBeginDrag(PointerEventData eventData)
  {
    Debug.Log("OnBeginDrag");
  }

  public void OnDrag(PointerEventData eventData)
  {
    Debug.Log("OnDrag");

    if (dropped)
    {
      return;
    }

    rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
  }

  public void OnEndDrag(PointerEventData eventData)
  {
    Debug.Log("OnEndDrag");

    if (dropped)
    {

      return;
    }

    float dist = Vector2.Distance(transform.position, target.transform.position);

    if (dist < 35)
    {
      OnSuccessfulDrop();
    }

    else
    {
      transform.position = startPos;
      // Hints.show = true;
      //Hints.setFalse();
      //Hints.CheckQuestion();
      Hints.ShowHints();
      Debug.Log("Wrong");
    }
  }

  public void OnSuccessfulDrop()
  {
    dropped = true;
    this.transform.position = target.transform.position;

    switch(key)
    {
      case "W":
        MovementL1.W = true;
        break;

      case "A":
        MovementL1.A = true;
        break;

      case "S":
        MovementL1.S = true;
        break;

      case "D":
        MovementL1.D = true;
        break;
    }
  }

  public void OnPointerDown(PointerEventData eventData)
  {
    Debug.Log("OnPointerDown");
  }
}
