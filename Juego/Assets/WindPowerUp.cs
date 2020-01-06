using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindPowerUp : MonoBehaviour
{
   void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {


            CharacterController2D character = collision.GetComponent<CharacterController2D>();
            character.ActivateDoubleJump();            
            SoundManager.PlaySound("PowerUpMedallon");
            Destroy(this.gameObject);
        }
    }
}
