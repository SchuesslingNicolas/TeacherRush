using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower_Cannon_Bullet_Movement : MonoBehaviour
{

    private Transform target;
    private float bulletSpeed = 50f;

    public void setTarget(Transform receifingTarget)
    {
        target = receifingTarget;
    }

    void Update()
    {

        if (target == null)
        {
            Destroy(gameObject);
            return;
        }

        Vector3 direction = target.position - transform.position;
        float distanceThisFrame = bulletSpeed * Time.deltaTime;

        if (direction.magnitude <= distanceThisFrame)
        {
            HitTarget();
            return;
        }
        
        transform.Translate(direction.normalized*distanceThisFrame, Space.World);

    }

    private void HitTarget()
    {
        Destroy(gameObject);
    }
}
