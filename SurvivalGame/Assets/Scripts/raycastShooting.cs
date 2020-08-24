using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raycastShooting : MonoBehaviour
{
    public Transform Effect;
    public int theDamage = 100;
    public RaycastHit hit;

    void Start()
    {

    }

    void Update()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(new Vector3((int)(Screen.width * 0.5), (int)(Screen.height * 0.5), 0));


        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(ray, out hit, 100))

            {
                Transform particle = Instantiate(Effect, hit.point, Quaternion.LookRotation(hit.normal));
                Destroy(particle.gameObject, 2);
                hit.transform.SendMessage("ApplyDamage", theDamage, SendMessageOptions.DontRequireReceiver);
            }
        }

    }
}
