using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDead : MonoBehaviour
{
    //public AudioSource aplastar;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            //aplastar.Play();
            SoundManager.PlaySound("Aplastar");
            Destroy(transform.parent.gameObject);
        }
    }
}
