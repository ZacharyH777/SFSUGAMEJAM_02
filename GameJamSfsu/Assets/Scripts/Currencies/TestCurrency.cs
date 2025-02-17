using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCurrency : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        CurrenciesManager.SetMoney(100);
        Debug.Log(CurrenciesManager.GetMoney());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
