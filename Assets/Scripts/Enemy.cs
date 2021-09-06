using System.Collections;
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

    public int pickUpChance;
    public GameObject[] pickUps;

    public int healthPickUpChance;
    public GameObject healthPickUp;

    public virtual void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }
    public void TakeDamage(int damageAmount)
    {
        health -= damageAmount;
        if(health <= 0)
        {
            int randomNumber = Random.Range(0, 101);
            if(randomNumber < pickUpChance)
            {
                GameObject randomPickup = pickUps[Random.Range(0, pickUps.Length)];
                Instantiate(randomPickup, transform.position, transform.rotation);
            }

            int healthRand = Random.Range(0, 101);
            if(healthRand < healthPickUpChance)
            {
                Instantiate(healthPickUp, transform.position, transform.rotation);
            }
            Destroy(this.gameObject);
        }        
    }
}
