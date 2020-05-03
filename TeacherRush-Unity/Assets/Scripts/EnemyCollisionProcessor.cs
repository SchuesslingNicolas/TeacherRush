using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollisionProcessor : MonoBehaviour
{
    public int life;
    private void OnTriggerEnter2D(Collider2D other)
    {
        life--;
        if (life>=0)
        {
            Destroy(gameObject);
        }
        
    }
}
