using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler{


    public void OnPointerEnter(PointerEventData eventData){
        //Debug.Log("OnEnter to " + gameObject.name);
    }
    public void OnPointerExit(PointerEventData eventData){
        //Debug.Log("OnExit to " + gameObject.name);
    }
    public void OnDrop(PointerEventData eventData){
        Debug.Log(eventData.pointerDrag.name + "OnDrop to " + gameObject.name);

        Draggable d = eventData.pointerDrag.GetComponent<Draggable>();
        if(d!=null){
            d.originalParent = this.transform;
        }

    }
}
