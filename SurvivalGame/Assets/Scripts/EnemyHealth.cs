﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int health = 100;

    // void EnemyUpdate()
    // {
       
    // }

    void ApplyDamage(int damage)
    {
        health -= damage;
         if (health <= 0)
        {
            Destroy(gameObject);
        }

    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    // void Update()
    // {
    //     EnemyUpdate();
    // }
}
