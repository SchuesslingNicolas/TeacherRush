using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower_Cannon : MonoBehaviour
{
    public GameObject towerCannonBulletPrefab;
    public Transform bulletSpawnPoint;
    public Transform target;
    public float range = 5f;
    public string enemyTag = "Enemy";
    private Vector2 targetPosition;
    //private float cooldown = 0.5f;
    void Start()
    {
        //Updates Targets all .5 seconds
        InvokeRepeating("UpdateTarget",0f,0.5f);
    }

    void UpdateTarget()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag(enemyTag);
        float shortestDistance = Mathf.Infinity;
        GameObject nearestEnemy = null;
        foreach (GameObject enemy in enemies)
        {
            float distanceToEnemy = Vector3.Distance(transform.position, enemy.transform.position);
            if (distanceToEnemy < shortestDistance)
            {
                shortestDistance = distanceToEnemy;
                nearestEnemy = enemy;
            }
        }

        if ((nearestEnemy != null) && (shortestDistance <= range))
        {
            target = nearestEnemy.transform;

            spawnBullet();

        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if (target==null)
        {
            
            return;
        }
        else
        {
            //dreht sich nach der position der Enemys
            
            var dir = target.position - transform.position;
            var angle =90 + Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
            target = null;
        }
    }
    
     void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, range);
    }


     void spawnBullet()
     {
        GameObject bulletGameObject = (GameObject) Instantiate(towerCannonBulletPrefab,bulletSpawnPoint.position, bulletSpawnPoint.rotation);
        Tower_Cannon_Bullet_Movement bullet = bulletGameObject.GetComponent<Tower_Cannon_Bullet_Movement>();

        if (bullet != null)
        {
            bullet.setTarget(target);
        }
     }
}
