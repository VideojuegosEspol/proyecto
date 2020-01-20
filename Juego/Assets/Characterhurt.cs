using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Characterhurt : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject padre;

    // void Star(){
    //     PlayerMovement player = padre.GetComponent<PlayerMovement>();
    // }


    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.tag);
        if (collision.tag == "Enemy")
        {           
            Debug.Log("holiii");
            

            PlayerMovement player = padre.GetComponent<PlayerMovement>();
            StartCoroutine(player.hurtAnimation());
            //PlayerMovement.life -= 11;
            //Debug.Log(PlayerMovement.life);
            //HealthBar.Heath = PlayerMovement.life;
            //PlayerMovement.evaluate();
            SoundManager.PlaySound("classic_hurt");



        }
    }
}
