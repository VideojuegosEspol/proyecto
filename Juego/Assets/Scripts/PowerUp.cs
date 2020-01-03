using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {            
            SoundManager.PlaySound("PowerUpMedallon");
            Destroy(this.gameObject);
        }
    }
}
