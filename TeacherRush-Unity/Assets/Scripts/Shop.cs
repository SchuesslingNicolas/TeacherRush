using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    private BuildManager buildManager;
    public static int prizeCannon = 500;
    public static int prizeBalista = 700;
    public static int prizeLifes = 1000;
    

    private void Start()
    {
        buildManager = BuildManager.instance;
    }

    public void purchaseCannon()
    {
        if (MoneyScript.Money>=prizeCannon)
        {
            Debug.Log("Buy Tower");
            buildManager.setTowerToBuild(buildManager.cannonTowerPrefab);
            MoneyScript.Money -= prizeCannon;
        }
    }
    
    public void purchaseBallista()
    {
        if (MoneyScript.Money>=prizeBalista)
        {
            Debug.Log("Buy Tower");
            buildManager.setTowerToBuild(buildManager.ballistaTowerPrefab);
            MoneyScript.Money -= prizeBalista;
        }
    }

    public void purchaseLifes()
    {
        if (MoneyScript.Money>=prizeLifes)
        {
            LifeScript.lifes += 20;
            MoneyScript.Money -= prizeLifes;
        }
        
    }
    
}
