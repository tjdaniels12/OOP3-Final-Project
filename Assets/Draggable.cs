using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Draggable : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler {
    private float cardSpeed = 10f;
    public Transform originalParent = null;
    ///Methods
    public void OnBeginDrag(PointerEventData eventData){
        Debug.Log("OnBeginDrag");

        originalParent = this.transform.parent;
        this.transform.SetParent(this.transform.parent.parent);
        //this.transform.position = Vector3.MoveTowards(this.transform.position, eventData.position, cardSpeed);

        GetComponent<CanvasGroup>().blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData cursor){
      //  Debug.Log("OnDrag");
        this.transform.position = cursor.position;
    }

    public void OnEndDrag(PointerEventData eventData){
        //Debug.Log("OnEndDrag");

        this.transform.SetParent(originalParent);
        GetComponent<CanvasGroup>().blocksRaycasts = true;
    }

}
