using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdvancedAI : MonoBehaviour
{

    public float Distance;
    public Transform Target;
    public float lookAtDistance = 25.0f;
    public float attackRange = 1.5f;
    public float chaseRange = 15.0f;
    public float moveSpeed = 5.0f;
    public float Damping = 6.0f;
    //to call the movement thrug controller
    public int attackRepeatTime = 5;
    private float attacktime;

    public CharacterController controller;
    public float gravity = 20f;
    private Vector3 moveDirection = Vector3.zero;
    Renderer rend;


    public int damage = 40;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        attacktime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        Distance = Vector3.Distance(Target.position, transform.position);

        if (Distance < lookAtDistance)
        {
            rend.material.color = Color.yellow;
            lookAt();
        }
        if (Distance > lookAtDistance)
        {
            rend.material.color = Color.green;
        }

        if (Distance < attackRange)
        {
            attack();
        }
        else if (Distance < chaseRange)
        {
            chase();
        }

    }

    void lookAt()
    {
        Quaternion rotation = Quaternion.LookRotation(Target.position - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * Damping);
    }
    void chase()
    {
        rend.material.color = Color.red;
        moveDirection = transform.forward;
        moveDirection *= moveSpeed;
        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

    }
    void attack()
    {

        if (Time.time > attacktime)
        {
            rend.material.color = Color.blue;
            Debug.Log("Enemy has atatcked");
            Target.SendMessage("damagePlayer", damage);
            attacktime = Time.time + attackRepeatTime;

        }
    }
    void ApplyDamage()
    {
        chaseRange += 30;
        moveSpeed += 2;
        lookAtDistance += 40;
    }
}