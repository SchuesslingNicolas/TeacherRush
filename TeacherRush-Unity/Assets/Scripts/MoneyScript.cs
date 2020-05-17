using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyScript : MonoBehaviour
{
    public int startMoney = 50;
    public static int Money { get; set; }
    private Text moneyText;
    
    void Start()
    {
        Money = startMoney;
        moneyText = GetComponent<Text>();
    }

    
    void Update()
    {
        moneyText.text = "" + Money + "$";
    }
}
