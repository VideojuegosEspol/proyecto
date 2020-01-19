using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoEnemy : MonoBehaviour
{
    [SerializeField]
    GameObject bullet;

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
            Instantiate(bullet, transform.position, Quaternion.identity);
            nextFire = Time.time + velocidadFuego;
        }
    }
}
