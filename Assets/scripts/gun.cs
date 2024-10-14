using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun : MonoBehaviour
{
    [SerializeField] Camera playerCam;
    [SerializeField] ParticleSystem muzzleFlash; 
    [SerializeField] float raycastRange = 100f;
    [SerializeField] GameObject hitVFX;
    [SerializeField] float damage = 10f; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) shoot();
        {
            shoot();
        }
        

    }

    private void shoot()
    {
        ProcessRaycast();
        PlayMuzzleFlash();
    }

    private void ProcessRaycast()
    {
        RaycastHit somethingHit;
        if (Physics.Raycast(playerCam.transform.position, playerCam.transform.forward, out somethingHit, raycastRange))
        {
            CreateHitEffect(somethingHit);
            EnemyHealth enemyTarget = somethingHit.transform.GetComponent<EnemyHealth>();
            enemyTarget.Damaged(damage);
        }

    }

    private void PlayMuzzleFlash()
    {
        muzzleFlash.Play();
    }

    private void CreateHitEffect(RaycastHit somethingHit)
    {
        GameObject impact = Instantiate(hitVFX, somethingHit.point, Quaternion.identity);
        Destroy(impact, 0.1f);
    }
}
