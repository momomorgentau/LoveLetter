using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//見かけに関すること
//データに関すること
public class CardController : MonoBehaviour
{
    public CardView view; // 見かけに関すること
    public CardModel model; //データに関すること
    public CardMovement cardMovement;
    public UIManager uIManager;

    private void Awake()
    {
        view = GetComponent<CardView>();
        cardMovement = GetComponent<CardMovement>();

    }

    public void Init(int cardID)
    {
        model = new CardModel(cardID);
        view.Show(model);
        SetUp();
    }

    private void SetUp() 
    {
        cardMovement.tapCardMethod = UpdateText;
        cardMovement.dropCardMethod = DropCard;

    }
    //タップされたときに呼ばれる
    private void UpdateText() 
    {
        GameManager.instance.uIManager.UpdateText(model);
        //gameuIManager.UpdateText(model);
    }

    //捨て札に置かれたカードの情報を取得
    private void DropCard() 
    {
        Debug.Log(model.name);
    }

}
