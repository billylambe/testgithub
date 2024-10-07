using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun : MonoBehaviour
{
    [SerializeField] Camera playerCam;
    [SerializeField] float raycastRange = 100f; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) shoot();
        

    }

    private void shoot()
    {
        RaycastHit Hitinfo;
        RaycastHit somethingHit;
        Physics.Raycast(playerCam.transform.position, playerCam.transform.forward, out Hitinfo, raycastRange);

    }
}
