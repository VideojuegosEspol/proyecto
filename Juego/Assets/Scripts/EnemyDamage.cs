﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyDamage : MonoBehaviour
{
    public float damage;
    //public GameObject player;
    //private Animator animator;
    private void OnTriggerEnter2D(Collider2D collision)
    {   
        if (collision.tag == "Player")
        {
            //Aqui iria la variable vida del Player 
            //      animator = player.GetComponent<Animator>();
            //PlayerMovement.animator.SetBool("IsJumping",true);
            

            //PlayerMovement playerMovement = collision.GetComponent<PlayerMovement>();
            //StartCoroutine(playerMovement.hurtAnimation());
            PlayerMovement.life -= damage;
            Debug.Log(PlayerMovement.life);
            HealthBar.Heath = PlayerMovement.life/3;
            PlayerMovement.evaluate();
            SoundManager.PlaySound("classic_hurt");
        }
    }
}
