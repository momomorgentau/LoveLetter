using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardView : MonoBehaviour
{

    [SerializeField] Image iconImage;
    [SerializeField] Image powerImage;


    private CardTextData cardTextData;
    private void Start()
    {
        
    }

    public void Show(CardModel cardModel) 
    {
        iconImage.sprite = cardModel.icon;
        powerImage.sprite = cardModel.powerIcon;
    }


}
