using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{

    //手札にカードを生成
    [SerializeField] CardController cardPrefab;
    [SerializeField] Transform playerHandTransform;
    //捨て札のコンポーネント
    [SerializeField] Transform playerFieldTransform;
    //UIを取得
    [SerializeField] public UIManager uIManager;

    bool playerTurn;


    //シングルトン化
    public static GameManager instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else 
        {
            DontDestroyOnLoad(this.gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
        
    }

    void StartGame()
    {
        InitHand();
        PlayerTurn();
    }

    void InitHand() 
    {
        CreateCard(playerHandTransform);

    }

    public void CreateCard(Transform hand)
    {
        CardController card = Instantiate(cardPrefab, hand);
        card.Init(Random.Range(1,9));
    }

    void PlayerTurn() 
    {
        Debug.Log("Player Turn");
        CreateCard(playerHandTransform);
    }

    void TurnEnd() 
    {

    }

    void DropCard() 
    {
        
    }


}
