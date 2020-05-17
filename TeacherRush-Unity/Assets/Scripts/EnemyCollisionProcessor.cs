using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollisionProcessor : MonoBehaviour
{
    public AudioSource hit;
    public int life;

    private void Start()
    {
        hit = GetComponent<AudioSource> ();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        life--;
        hit.Play();
        if (life>=0)
        {
            Destroy(gameObject);
            MoneyScript.Money += 10;
        }
        
    }
}
