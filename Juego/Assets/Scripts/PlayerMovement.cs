using System.Collections;
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

    public static float life = 300; 
   

    private bool fireBallSkill = false;


    


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
            
            //animator.SetBool("IsAttacking",true);
            //sword.SetActive(true);
            StartCoroutine(Attack());
        }
        // if(Input.GetButtonUp("Fire2")){
        //     animator.SetBool("IsAttacking",false);
        //     sword.SetActive(false);
        // }

        //Debug.Log(life);


        


    }


    // void Attack(){

    //     animator.SetTrigger("Attack");
    //     sword.SetActive(false);

    // }


    public void OnLanding(){

        animator.SetBool("IsJumping",false);
        

    }


    void FixedUpdate(){
        //Move character
        
        controller.Move(HorizontalMove*Time.fixedDeltaTime ,false,jump);
        
        jump=false;
        
        

    }






    // IEnumerator OnTriggerEnter2D(Collider2D collision){

    //     Debug.Log(collision.tag);
    //     if (collision.tag == "Enemy")
    //     {           
    //         Debug.Log("holiii");
    //         //Debug.Log();
    //         yield return new WaitForSeconds(5);
    //         animator.SetBool("Player_hurt",true);
            
    //         //animation.Stop(""); 
            
    //         //evaluate();
    //     }



    // }


    IEnumerator Attack(){

        sword.SetActive(true);
        animator.SetTrigger("Attack");

        yield return new WaitForSeconds(0.25f);
        sword.SetActive(false);

    }


    public void ThrowFireBall(){


        animator.SetTrigger("Fire");


    }


    public IEnumerator hurtAnimation(){


        animator.SetBool("IsHurt",true);
        yield return new WaitForSeconds(0.25f);
        animator.SetBool("IsHurt",false);



    }

    // void OnTriggerEnter2D(Collider2D collision)
    // {
    //     Debug.Log(collision.tag);
    //     if (collision.tag == "Enemy")
    //     {           
    //         //Debug.Log("holiii");
    //         //Debug.Log();
    //         //animator.SetBool("IsHurt",true);
    //         //yield WaitForSeconds(5);
    //         //animation.SetBool("IsHurt",false); 
            
    //         //evaluate();
    //         StartCoroutine(hurtAnimation());
    //     }
    // }

    public static void evaluate(){

        if(life<=0){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            life=100;
        }

    }



    public bool GetFireSkill(){
        return fireBallSkill;
    }

    public void ActivateFireSkill(){

        fireBallSkill = true;
    }



}
