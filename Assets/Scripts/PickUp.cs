using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public Weapon_1 weaponToEquip;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag ==  "Player")
        {
            collision.GetComponent<Player>().ChangeWeapon(weaponToEquip);
            Destroy(gameObject);
        }
    }
}
