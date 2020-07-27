using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//プレイヤーを管理する
public class PlayerManager : MonoBehaviour
{
    [SerializeField]
    public CardManager cardManager1;
    public CardManager cardManager2;



    private void Start()
    {
        uIManager.CardUISetUp();
        
    }


    [SerializeField]
    private UIManager uIManager;
    //カードをタップした際の挙動を登録
    public void SetUp()
    {
        //CardManager.card = 
        //cardManager2.AddEventListenerOnTap(() => uIManager.UpdateText(cardManager2));
    }
}
