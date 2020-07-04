using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour
{
    float currentSpeed = 1f;
    float speed;

    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(Vector2.right * currentSpeed * Time.deltaTime );
    }
    public void SetMovementSpeed(float speed)
    {
        currentSpeed = speed;
    }
}

