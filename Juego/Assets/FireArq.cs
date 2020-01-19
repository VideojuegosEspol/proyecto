using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireArq : MonoBehaviour
{
    [SerializeField]

    public Transform firePoint;
    public GameObject bulletPrefab;
    public Animator animacion;
    public Transform player;

    //public GameObject bullet;

    public float velocidadFuego;
    float nextFire;

    // Start is called before the first frame update
    void Start()
    {
        //velocidadFuego = 1f;
        nextFire = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        CheckIfTimeToFire();
    }

    //Comprueba el tiempo del ultimo disparo dado.
    void CheckIfTimeToFire()
    {
        if (Time.time > nextFire)
        {
            //Instanciamos la bala
            animacion.SetTrigger("Attack");
            Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            nextFire = Time.time + velocidadFuego;
        }
    }

    // Update is called once per frame
    /*
    void Update()
    {
        StartCoroutine(CheckDistance());


    }


    IEnumerator Shoot()
    {
        
        yield return new WaitForSeconds(2f);
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }

    IEnumerator CheckDistance()
    {
        
        Vector2 direction = player.position - transform.position;
        // animacion.SetTrigger("Walk");
        //Debug.Log(direction.x);
        //animacion.SetTrigger("Attack"); 
        if (Mathf.Abs(direction.x) < 10)
        {
            yield return new WaitForSeconds(5f);
            animacion.SetTrigger("Attack");
            StartCoroutine(Shoot());
            //Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            //Debug.Log("Funciona");
        }
        else
        {
            //Debug.Log("caminar");
            animacion.SetTrigger("Walk");
        }

    }*/
}
