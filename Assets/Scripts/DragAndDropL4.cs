using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragAndDropL4 : MonoBehaviour, IPointerDownHandler, IEndDragHandler, IDragHandler
{
  [SerializeField] private Canvas canvas;
  private RectTransform rectTransform;
  public MovementL4 player;
  public DroppableL4 target;
  public int value;
  private bool dropped;
  private Vector2 startPos;

  private void Awake()
  {
    // startPos = transform.position;
    // Debug.Log(startPos);
    rectTransform = GetComponent<RectTransform>();
    startPos = rectTransform.anchoredPosition;
  }

  public void Return()
  {
    dropped = false;
    rectTransform.anchoredPosition = startPos;
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
      Return();
    }
  }

  public void OnSuccessfulDrop()
  {
    dropped = true;
    this.transform.position = target.transform.position;
    // rectTransform.anchoredPosition = target.GetComponent<RectTransform>().anchoredPosition;
    player.numBullets = this.value;

    if(target.draggable != null)
    {
      target.draggable.Return();
    }
    target.draggable = this;
  }

  public void OnPointerDown(PointerEventData eventData)
  {
    Debug.Log("OnPointerDown");
  }
}
