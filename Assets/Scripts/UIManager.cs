using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//カードのUIを管理
public class UIManager : MonoBehaviour
{


    public void CardUISetUp()
    {
        cardPowerText.text = "";
        cardTextText.text = "";
        cardNameText.text = "";
    }

    [SerializeField]
    private Text cardPowerText;
    [SerializeField]
    private Text cardTextText;
    [SerializeField]
    private Text cardNameText;

    //カード情報のアップデート
    public void UpdateText(CardManager cardManager)
    {
        cardPowerText.text = string.Format("{0}", cardManager.CardPower);
        cardTextText.text = string.Format("{0}", cardManager.CardText);
        cardNameText.text = cardManager.CardText;
    }
}
