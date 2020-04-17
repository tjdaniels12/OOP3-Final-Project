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
        
        Draggable d = eventData.pointerDrag.GetComponent<Draggable>();
        if(d.inPlay) return;

        Debug.Log(eventData.pointerDrag.name + " OnDrop to " + gameObject.name);
        
        

        if(d!=null){
            d.originalParent = this.transform;
        }
        if(gameObject.name == "Table"){
            if(!d.inPlay){
                GameObject droppedCard = eventData.pointerDrag;
                droppedCard.GetComponent<CardDisplay>().onPlay();
            }
            d.inPlay=true;
        }

    }
}
