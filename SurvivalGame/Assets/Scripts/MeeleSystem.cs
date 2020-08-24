using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeeleSystem : MonoBehaviour
{
    public int damage = 50;
    public float distance;
    public float maxDistance = 1.5f;

    public Transform TheSystem;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //attack animation
            Animation animation = GetComponent<Animation>();
            animation.Play("Attack");
            //attack function

        }
        // if (TheMace.GetComponent<Animation>().isPlaying == false)
        // {
        //     // TheMace.GetComponent<Animation>().Play("idle");
        //     TheMace.GetComponent<Animation>().CrossFade("idle");
        // }
        // if (Input.GetKey(KeyCode.LeftShift))
        // {
        //     TheMace.GetComponent<Animation>().CrossFade("Sprint");
        // }
        // if (Input.GetKeyUp(KeyCode.LeftShift))
        // {
        //     TheMace.GetComponent<Animation>().CrossFade("idle");

        // }
    }



    void AttackDamage()
    {
        RaycastHit hit;
        if (Physics.Raycast(TheSystem.transform.position, TheSystem.transform.TransformDirection(Vector3.forward), out hit))
        {

            distance = hit.distance;
            if (distance <= maxDistance)
            {
                hit.transform.SendMessage("ApplyDamage", damage, SendMessageOptions.DontRequireReceiver);
            }
        }
    }

}

