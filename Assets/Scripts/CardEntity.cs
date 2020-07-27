using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CardEntity", menuName = "Create CardEntity")]
public class CardEntity : ScriptableObject
{
                                                                                                            public new string name;
    public string nameJP;
    public string text;
    public int power;
    public Sprite icon;
    public Sprite powerIcon;

}
