using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragAndDropL3 : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
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
    var mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;;
    // eventData.delta / canvas.scaleFactor;
  }

  public void OnEndDrag(PointerEventData eventData)
  {
    Debug.Log("OnEndDrag");

    if (dropped)
    {
      return;
    }

    float dist = Vector2.Distance(transform.position, target.transform.position);

    if (dist < 3)
    {
      OnSuccessfulDrop();
    }

    else
    {
      transform.position = startPos;
    }
  }

  public void OnSuccessfulDrop()
  {
    dropped = true;
    this.transform.position = target.transform.position;
    var droppable = target.GetComponent<DroppableL3>();
    droppable.draggable = this;
  }

  public void OnPointerDown(PointerEventData eventData)
  {
    Debug.Log("OnPointerDown");
  }
}
