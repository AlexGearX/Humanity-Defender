using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] float health = 100f;
    Animator animator;

    private void Start()
    {
      animator = GetComponent<Animator>();  
    }
    

    public void DealDamage(float damage)
    {
        health -= damage;
        if (health <= 0)
        {
            //animator.SetBool("isDie", true);
            //StartCoroutine(Die());
            //call death animation / particule 139(course)
            Destroy(gameObject);
        }
    }

    IEnumerator Die()
    {
        yield return new WaitForSeconds(1);
        Destroy(gameObject);
    }


}
