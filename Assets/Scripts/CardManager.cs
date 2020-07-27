using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//カードを管理する
public class CardManager : MonoBehaviour
{
    //関数登録
    //Action tapAction;
    [SerializeField]
    private string cardName;
    [SerializeField]
    private string cardNameJp;
    [SerializeField]
    private int cardPower;
    private string cardText;

    public string CardName
    {
        get { return cardName; }
        set { cardName = value; }
    }


    public int CardPower
    {
        get { return cardPower; }
        set { cardPower = value; }
    }

    public string CardText
    {
        get { return cardText; }
        set { cardText = value; }
    }



    private CardTextData cardTextData;

    private void Start()
    {
        cardTextData = GetComponent<CardTextData>();
        cardText = cardTextData.GetCardText(cardName);
    }

    //関数登録
    Action tapAction;

    public void AddEventListenerOnTap(Action action) 
    {
        tapAction += action;
    }

    public void OnTap()
    {
        tapAction();
    }

    //カードを捨てる処理
    public void ThrowCard() 
    {
        Destroy(this.gameObject);
    }
}
