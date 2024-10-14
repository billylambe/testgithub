using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerhealth : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float playerHealthPoints = 30f;


    public void Damaged(float damage)
    {
        GetComponent<enemyattack>().

        playerHealthPoints -= damage;
        if (playerHealthPoints <= 0)
        {
            print("dead");
        }

    }

}
