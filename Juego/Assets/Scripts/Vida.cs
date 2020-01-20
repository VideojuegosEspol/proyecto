using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vida : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {            
            SoundManager.PlaySound("Vida");
            //Aqui iria la variable vida del Player 
            PlayerMovement.life = 100; //Aumentamos a 100 (vida completa)
            HealthBar.Heath = PlayerMovement.life;
            Destroy(transform.gameObject);
        }
    }
}
