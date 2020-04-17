using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Draggable : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler {
    private float cardSpeed = 10f;
    public Transform originalParent = null;
    public LineRenderer line;
    public bool inPlay = false; 


    GameObject placeholder = null;
    ///Methods
    public void OnBeginDrag(PointerEventData eventData){
        Debug.Log("OnBeginDrag");


        if (this.transform.parent.gameObject == GameObject.Find("Table"))
        {
            Debug.Log("Object is on the table");
            if (line == null)
            {
                line = new GameObject("Line").AddComponent<LineRenderer>();
            }
        }
        else
        {

            placeholder = new GameObject();
            placeholder.transform.SetParent(this.transform.parent);

            LayoutElement le = placeholder.AddComponent<LayoutElement>();
            le.preferredWidth = this.GetComponent<LayoutElement>().preferredWidth;
            le.preferredHeight = this.GetComponent<LayoutElement>().preferredHeight;
            le.flexibleHeight = 0;
            le.flexibleWidth = 0;

            placeholder.transform.SetSiblingIndex(this.transform.GetSiblingIndex());



            originalParent = this.transform.parent;
            this.transform.SetParent(this.transform.parent.parent);
            //this.transform.position = Vector3.MoveTowards(this.transform.position, eventData.position, cardSpeed);

            GetComponent<CanvasGroup>().blocksRaycasts = false;
        }
    }

    public void OnDrag(PointerEventData cursor){
        //if(inPlay) return;
        //  Debug.Log("OnDrag");
        if (this.transform.parent.gameObject == GameObject.Find("Table"))
        {
            Debug.Log("Object is on the table");

            line.SetWidth(40, 5);
            line.SetColors(Color.red, Color.green);
            line.SetVertexCount(2);
            line.SetPosition(0, this.transform.position);
            line.SetPosition(1, cursor.position);
        }
        else
        {
            this.transform.position = cursor.position;
            int newSiblingIndex = originalParent.childCount;

            for (int i = 0; i < originalParent.childCount; i++)
            {
                if (this.transform.position.x < originalParent.GetChild(i).position.x)
                {
                    newSiblingIndex = i;

                    if (placeholder.transform.GetSiblingIndex() < newSiblingIndex)
                    {
                        newSiblingIndex--;
                    }
                    break;
                }
            }

            placeholder.transform.SetSiblingIndex(newSiblingIndex);

        }
        
    }

    public void OnEndDrag(PointerEventData eventData){
        Debug.Log("OnEndDrag");

        if (this.transform.parent.gameObject == GameObject.Find("Table"))
        {
            Debug.Log("Object is on the table");
        }
        else
        {
            this.transform.SetParent(originalParent);
            this.transform.SetSiblingIndex(placeholder.transform.GetSiblingIndex());
            GetComponent<CanvasGroup>().blocksRaycasts = true;
            Destroy(placeholder);
        }
    }

}
