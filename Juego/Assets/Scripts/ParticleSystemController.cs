using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleSystemController : MonoBehaviour
{
    private ParticleSystem particula;

     void Start()
    {
        particula = GetComponent<ParticleSystem>();
    }

    void OnParticleCollision(GameObject other)
    {
        if (other.tag == "Player")
        {
            //Player -= Life -10;
        }
    }

    private void OnParticleTrigger()
    {
        
    }

    /*void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            myObject.SetActive(true);
        }
    }*/
}
