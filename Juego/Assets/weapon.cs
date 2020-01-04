using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;

    // Update is called once per frame
    void Update() 
    {
        if (Input.GetButtonDown("Fire1"))
        {
            PlayerMovement pm = this.GetComponent<PlayerMovement>();
            pm.ThrowFireBall();
            StartCoroutine(Shoot());
        }
    }





    IEnumerator Shoot() {
        yield return new WaitForSeconds(0.6f);
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }


}
