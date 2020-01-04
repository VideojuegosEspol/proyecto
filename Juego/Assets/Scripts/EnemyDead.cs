    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDead : MonoBehaviour
{
    //public AudioSource aplastar;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Sword")
        {
            //aplastar.Play();
            Died();
        }
    }


    public void Died(){
            SoundManager.PlaySound("Aplastar");
            Destroy(transform.parent.gameObject);
    }


}
