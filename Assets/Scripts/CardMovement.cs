using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CardMovement : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    //カードをタップした時のメソッドを登録
    public delegate void TapCardMethod();
    public  TapCardMethod tapCardMethod;

    public delegate void DropCardMethod();
    public DropCardMethod dropCardMethod;

    //カードの親
    public Transform defaultParent;

    public void OnBeginDrag(PointerEventData eventData)
    {
        defaultParent = transform.parent;
        //親の親を取得する(祖父母の子になる)
        transform.SetParent(defaultParent.parent, false);
        //移動させるときはrayblockをtrueにする
        GetComponent<CanvasGroup>().blocksRaycasts = false;
        tapCardMethod();

    }

    public void OnDrag(PointerEventData eventData) 
    {
        transform.position = eventData.position;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        //離した際には元の親に戻る
        transform.SetParent(defaultParent, false);
        GetComponent<CanvasGroup>().blocksRaycasts = true;

    }

    //DropPlaceにて実行される。dropされたカードの情報をmodelを含めて上に投げる。
    public void GetDropCardData()
    {
        dropCardMethod();
    }
}
