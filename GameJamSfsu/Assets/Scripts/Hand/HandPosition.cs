using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HandPosition : MonoBehaviour
{
    public static int HANDSIZE = 7;  

    private Vector3[] odd_card_positions = new Vector3[HANDSIZE];
    private Vector3[] even_card_positions = new Vector3[HANDSIZE-1];


    void Awake()
    {
        GenerateCardPositions();
    }

    // Update is called once per frame
    void Update()
    {
           
    }


    private void GenerateCardPositions()
    {
        Vector3 hand_position = this.transform.position;
        
        for (int i = 0; i < HANDSIZE; i++)
        {
            odd_card_positions[i] = new Vector3((i) * 1.5f, 0, 0) + hand_position;
            Debug.Log("Vector odd position: " + odd_card_positions[i]);
        }

        for (int i = 0; i < HANDSIZE - 1; i++)
        {
            if (i % 2 == 0)

            even_card_positions[i] = new Vector3((i + 0.5f) * 1.5f, 0, 0) + hand_position;
            
            Debug.Log("Vector even position: " + even_card_positions[i]);
        }
    }
}
