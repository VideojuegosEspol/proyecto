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
            Debug.Log("Muerte");
            //aplastar.Play();
            Died();
        }
    }


    public void Died(){
        Destroy(transform.parent.gameObject);
        SoundManager.PlaySound("Aplastar");
            
    }


}
