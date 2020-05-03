using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public static BuildManager instance;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("More than one BuildManager in scene!");
                    return;
        }

        instance = this;

    }

    public GameObject cannonTowerPrefab;
    public GameObject ballistaTowerPrefab;

    private GameObject towerToBuild;

    public GameObject getTowerToBuild()
    {
        return towerToBuild;
    }

    public void setTowerToBuild(GameObject tower)
    {
        towerToBuild = tower;
        Debug.Log(tower);
    }
}
