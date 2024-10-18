using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyattack : MonoBehaviour
{
    [SerializeField] playerhealth playerTarget;
    [SerializeField] float playerdamage = 5f;

    public void AttackHitAnimEvent()
    {
        if (playerTarget == null) return;
        playerTarget.Damaged(playerdamage);
    }
}
