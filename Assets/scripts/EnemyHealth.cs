using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{

    [SerializeField] float healthPoints = 30f;


    public void Damaged(float damage)
    {
       
        
        healthPoints -= damage;
        if (healthPoints <= 0)
        {
            Destroy(gameObject);   
        }

        Aggro();
    }

    public void Aggro()
    {
        if (healthPoints <= 30)
        {

        }
    }
}
