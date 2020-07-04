using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] float health = 100f;

    public void DealDamage(float damage)
    {
        health -= damage;
        if (health <= 0)
        {
            //call death animation / particule 139(course)
            Destroy(gameObject);
        }
    }



}
