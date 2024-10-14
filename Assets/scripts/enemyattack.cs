using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyattack : MonoBehaviour
{
    [SerializeField] Transform playerTarget;
    [SerializeField] float playerdamage = 5f;

    public void AttackHitAnimEvent()
    {
        if (playerTarget == null) return;
        print("enemy damaged player");
    }
}
