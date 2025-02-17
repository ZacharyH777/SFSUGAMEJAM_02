using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawFromDeck : MonoBehaviour
{
    private bool onlyOnce = false;

    private string cardResourcePath = "cards/card";
    private string handResourcePath = "Hand/HandVisual";
    GameObject cardPrefab;
    GameObject handPrefab;

    int DeckSize = 20;
    void Awake ()
    {
        handPrefab = Instantiate (
            Resources.Load<GameObject>(handResourcePath),
            new Vector3(.5f, -12.4f, 0f), 
            Quaternion.Euler(0,0,180)
        );
        cardPrefab = Resources.Load<GameObject>(cardResourcePath);

        for(int i = 0; i < DeckSize; i++)
        {
            GameObject card = Instantiate(cardPrefab, transform.position, Quaternion.identity);
            card.transform.SetParent (handPrefab.transform.GetChild(0));
            ClickAndDrag cardOrder = card.GetComponent<ClickAndDrag>();

            cardOrder.setCardOrder(i);
            card.name = "Card_" + (i + 1);
        }
    }
    void Update()
    {
        if(StartScreenTimer.get_time() > 2.5f && !onlyOnce)
        {
            
            onlyOnce = true;
        }
    }
}
