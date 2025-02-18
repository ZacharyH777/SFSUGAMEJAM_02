using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Burst;
using UnityEngine;

public class ScriptableCard : ScriptableObject
{
    public string cardName;
    public string cardDescription;
    public int storeCost;
    public string artPath;
    public int cardType;
    public Action<int> cardAction;
    public bool isDraggable;
    public bool tempCard;
}
