using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleManager : MonoBehaviour
{
    [SerializeField]
    private GameObject[] cardPrefabs;
    [SerializeField]
    private PlayerManager playerManager;

    public void DrawCard() 
    {
        GameObject card = Instantiate(cardPrefabs[0]);
        playerManager.cardManager2 = card.GetComponent<CardManager>();
        playerManager.SetUp();
    }

}
