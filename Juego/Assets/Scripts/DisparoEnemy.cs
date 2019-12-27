using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoEnemy : MonoBehaviour
{
    [SerializeField]
    GameObject bullet;
    public float VelocidadFuego;
    public float NextFire;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CheckIfTimeToFire();
    }

    //Comprueba el tiempo del ultimo disparo dado.
    void CheckIfTimeToFire()
    {
        if (Time.time > NextFire)
        {
            Instantiate(bullet, transform.position, Quaternion.identity);
            NextFire = Time.time + VelocidadFuego;
        }
    }
}
