using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class CardTextData : MonoBehaviour
{
    public string GetCardText(string cardName) 
    {
        string cardText = "text";
        switch (cardName)
        {
            case "kousotsu":
                cardText = "他のプレイヤーを一人選び「こうそつ」以外のカードを1つ指定する。" +
                    "手札と一致した場合にそのプレイヤーは脱落する。";
                break;
            case "haken":
                cardText = "他のプレイヤーを一人選び、その手札を見る。";
                break;
            case "はろーわーく":
                cardText = "他のプレイヤーを一人選び、互いの手札の強さを比べる。" +
                    "強さが小さいプレイヤーは脱落する。";
                break;
            case "shinsotsu":
                cardText = "あなたは次の自分の手番までカードの効果を受けない。";
                break;
            case "bucho":
                cardText = "プレイヤーを一人選ぶ。（あなたでもよい）" +
                    "そのプレイヤーは手札を捨て、山札から1枚引いて手札とする。";
                break;
            case "jinji":
                cardText = "他のプレイヤーを一人えらび、手札を交換する。";
                break;
            case "claimer":
                cardText = "あなたの手札の強さの合計が12以上の場合、脱落する。";
                break;
            case "shacho":
                cardText = "このカードが捨てられた場合、脱落する。";
                break;
            case "hoisotsu":
                cardText = "このカードを持つプレイヤーは、脱落する。";
                break;
            default:
                cardText = "未割当";
                break;
        }
        return cardText;
    }
}
