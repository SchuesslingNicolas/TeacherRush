using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceTower : MonoBehaviour
{

    private GameObject tower;
    private Vector3 mousPos;
    public Camera camera;

    BuildManager buildManager;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Do you even Start");
        buildManager = BuildManager.instance;
    }


     void OnMouseDown()
    {
        if (buildManager.getTowerToBuild()==null)
        {
            return;
        }
        if (tower != null)
        {
            return;
        }

        getMousePos();
        Debug.Log(mousPos);
        GameObject towerToBuild = buildManager.getTowerToBuild();
        Instantiate(towerToBuild).transform.position = mousPos;
        buildManager.setTowerToBuild(null);
    }

    private void getMousePos()
    {
        mousPos = camera.ScreenToWorldPoint(Input.mousePosition);
        mousPos.z = 0;
        Debug.Log(mousPos);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
