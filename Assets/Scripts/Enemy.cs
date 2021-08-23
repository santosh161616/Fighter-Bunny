﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health;
    [HideInInspector]
    public Transform player;
    public int damage; 
    public float speed;
    public float timeBetweenAttacks;

    public virtual void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }
    public void TakeDamage(int damageAmount)
    {
        health -= damageAmount;
        if(health <= 0)
        {
            Destroy(gameObject);
        }        
    }
}
