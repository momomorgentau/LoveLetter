using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//プレイヤーを管理する
public class PlayerManager : MonoBehaviour
{
    [SerializeField]
    private CardManager cardManager;


    private void Start()
    {
        uIManager.CardUISetUp();
        SetUp();
    }


    [SerializeField]
    private UIManager uIManager;
    //カードをタップした際の挙動を登録
    private void SetUp()
    {
        cardManager.AddEventListenerOnTap(() => uIManager.UpdateText(cardManager));
    }
}
