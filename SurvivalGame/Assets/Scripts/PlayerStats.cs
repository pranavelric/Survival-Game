using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{

    public int health = 100;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void damagePlayer(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            RespawnMenu.isplayerdead = true;

            // Destroy(gameObject);
            Debug.Log("Player dead");
        }

    }


}
