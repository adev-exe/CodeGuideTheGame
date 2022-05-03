using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnthonyMove : MonoBehaviour
{

    public GameObject CorrectForm;
    private bool moving;
    private bool finished;


    private float startPOSX;
    private float startPOSY;

    private Vector3 resetPosition;

    // Start is called before the first frame update
    void Start()
    {
        resetPosition = this.transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        if(finished == false)
        {
                if (moving)
                        {
                            Vector3 mousePos;
                            mousePos = Input.mousePosition;
                            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

                            this.gameObject.transform.localPosition = new Vector3(mousePos.x - startPOSX, mousePos.y - startPOSY, this.gameObject.transform.localPosition.z);
                        }
        }
        
        
    }

    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            startPOSX = mousePos.x - this.transform.localPosition.x;
            startPOSY = mousePos.y - this.transform.localPosition.y;

            moving = true;
        }
    }

    private void OnMouseUp()
    {
        moving = false;


        if (Mathf.Abs(this.transform.localPosition.x - CorrectForm.transform.localPosition.x) <= 0.5f &&
            Mathf.Abs(this.transform.localPosition.y - CorrectForm.transform.localPosition.y) <= 0.5f)
        {
            this.transform.localPosition = new Vector3(CorrectForm.transform.localPosition.x, CorrectForm.transform.localPosition.y, CorrectForm.transform.localPosition.z);
            finished = true;

            GameObject.Find("PointsHolder").GetComponent<WinScript2>().addPoints();
        }
        else
        {
            this.transform.localPosition = new Vector3(resetPosition.x, resetPosition.y, resetPosition.z);
             Hints.ShowHints();
             Debug.Log("Wrong");
        }
    }
}
