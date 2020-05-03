using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    private BuildManager buildManager;

    private void Start()
    {
        buildManager = BuildManager.instance;
    }

    public void purchaseCannon()
    {
        Debug.Log("Buy Tower");
        buildManager.setTowerToBuild(buildManager.cannonTowerPrefab);
    }
    
    public void purchaseBallista()
    {
        Debug.Log("Buy Tower");
        buildManager.setTowerToBuild(buildManager.ballistaTowerPrefab);
    }
    
}
