using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponsSwitching : MonoBehaviour
{
    public GameObject Weapon1;
    public GameObject Weapon2;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            SwapWeapons();
        }

    }
    void SwapWeapons()
    {
        if (Weapon1.active == true)
        {
            // Weapon1.SetActiveRecursively(false);
            Weapon1.SetActive(false);
            Weapon2.SetActive(true);
            // Weapon2.SetActiveRecursively(true);
        }
        else
        {
            Weapon1.SetActive(true);
            Weapon2.SetActive(false);

            // Weapon1.SetActiveRecursively(true);

            // Weapon2.SetActiveRecursively(false);
        }

    }
}
