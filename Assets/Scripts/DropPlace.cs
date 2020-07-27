using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

//カードをドロップさせる処理
public class DropPlace : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        //eventdataはカードのオブジェクト
        CardMovement card = eventData.pointerDrag.GetComponent<CardMovement>();
        if (card != null) 
        {
            card.defaultParent = this.transform;
        }
        if (this.transform.name == "PlayerField") 
        {
            card.GetDropCardData();
        }

    }

}
