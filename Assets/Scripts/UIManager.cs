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
    public void UpdateText(CardModel model)
    {
        cardPowerText.text = string.Format("{0}", model.power);
        cardTextText.text = model.text;
        cardNameText.text = model.nameJP;
    }
}
