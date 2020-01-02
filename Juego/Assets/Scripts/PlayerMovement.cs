﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{

    
    public CharacterController2D controller;
    public Animator animator;
    public float runSpeed = 40f;

    float HorizontalMove = 0f;

    bool jump = false;

    public GameObject sword;


    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {


        HorizontalMove = Input.GetAxisRaw("Horizontal")*runSpeed; 
        animator.SetFloat("Speed",Mathf.Abs(HorizontalMove));
        if (Input.GetButtonDown("Jump")){
            jump = true;
            animator.SetBool("IsJumping",true);
        }if(Input.GetButtonDown("Fire2")){
            
            animator.SetBool("IsAttacking",true);
            sword.SetActive(true);
            
        }if(Input.GetButtonUp("Fire2")){
            animator.SetBool("IsAttacking",false);
            sword.SetActive(false);
        }


    }

    public void OnLanding(){

        animator.SetBool("IsJumping",false);

    }


    void FixedUpdate(){
        //Move character
        controller.Move(HorizontalMove*Time.fixedDeltaTime ,false,jump);
        jump=false;

    }

}
