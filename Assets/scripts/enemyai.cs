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

    void Start()
    {
        nMA = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    private void Update()
    {
        distanceToPlayer = Vector3.Distance(target.position, transform.position);

        if(distanceToPlayer <= aggroRange) 
        {
            nMA.SetDestination(target.transform.position);
        }
    }
}
