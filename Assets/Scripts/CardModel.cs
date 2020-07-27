using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardModel
{
    public string name;
    public string nameJP;
    public string text;
    public int power;
    public Sprite icon;
    public Sprite powerIcon;


    public CardModel(int cardID) 
    {
        CardEntity cardEntity = Resources.Load<CardEntity>("CardEntityList/Card"+ cardID);
        name = cardEntity.name;
        nameJP = cardEntity.nameJP;
        text = cardEntity.text;
        power = cardEntity.power;
        icon = cardEntity.icon;
        powerIcon = cardEntity.powerIcon;


    }

}
