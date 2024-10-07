using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemyai : MonoBehaviour
{

    [SerializeField] Transform target; 
    NavMeshAgent nMA;
   

    float aggroRange = 5f;
    float distanceToPlayer;
    float attackRange = 2f;
    float turnSpeed = 5f;

    bool isAggro = false;
    bool attackState = false;
    bool chasePlayer = false;
    

    void Start()
    {
        nMA = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    private void Update()
    {
        distanceToPlayer = Vector3.Distance(target.position, transform.position);
        if (distanceToPlayer <= aggroRange) chasePlayer = true;

        if (chasePlayer);
        {
            
            nMA.SetDestination(target.transform.position);
            if (distanceToPlayer <= attackRange) attackState = true;
            else chasePlayer = true;

        }

        if(distanceToPlayer <= aggroRange) 
        {
            nMA.SetDestination(target.transform.position);
        }

        
    }

    void RotateToPlayer()
    {
        Vector3 direction = (target.position - transform.position).normalized;
        Quaternion currentRotation = transform.rotation;
        Quaternion desiredRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));

        Quaternion.Lerp(currentRotation, desiredRotation, Time.deltaTime * turnSpeed);
    }
}
