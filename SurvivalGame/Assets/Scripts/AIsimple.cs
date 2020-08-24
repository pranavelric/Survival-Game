using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AIsimple : MonoBehaviour
{

    public float Distance;
    public Transform Target;
    public float lookAtDistance = 25.0f;
    public float attackRange = 15.0f;
    public float moveSpeed = 5.0f;
    public float Damping = 6.0f;

    Renderer rend;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
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
            rend.material.color = Color.red;
            attack();
        }
    }

    void lookAt()
    {
        Quaternion rotation = Quaternion.LookRotation(Target.position - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * Damping);
    }
    void attack()
    {
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

    }
}
