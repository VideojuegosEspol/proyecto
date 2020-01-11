using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaterEnemyDead : MonoBehaviour
{
    public int health;
    public int damage;
    private float timeBtwDamage = 1.5f;
    public GameObject arma;


    public Animator animacion;

    public Slider healthBar;


    private void Start()
    {
        healthBar.gameObject.SetActive(false);
    }

    private void Update()
    {
        //healthBar.gameObject.SetActive(false);

        if (timeBtwDamage > 0)
        {
            timeBtwDamage -= Time.deltaTime;
        }
        
        healthBar.value = health;
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Sword"))
        {
            healthBar.gameObject.SetActive(true);
            animacion.SetTrigger("Hit");
            TakeDamage(8);
        }
        if (collision.CompareTag("FireBall") )
        {
            Debug.Log("bola de fuego");
            healthBar.gameObject.SetActive(true);
            animacion.SetTrigger("Hit");
            TakeDamage(10);

        }
        if (collision.CompareTag("ShieldObj"))
        {
            Debug.Log("shield");
            

        }
        if (health <= 0)
        {
            
            Died();
        }
    }

    public void TakeDamage(int lessdamage)
    {
        health -= lessdamage;
    }


    public void Died()
    {
        animacion.SetBool("isDead", true);
        SoundManager.PlaySound("Aplastar");
        
        GetComponent<CapsuleCollider2D>().enabled = false;
        this.enabled = false;
        healthBar.gameObject.SetActive(false);
        //groundDetection.gameObject.SetActive(false);
        transform.parent.gameObject.GetComponent<DetectarPiso>().enabled = false;
        arma.SetActive(false);
        //transform.parent.gameObject.

        //SetActive(false);
        // Destroy(this.gameObject);

    }



    public bool NoHealt()
    {

        if (health <= 0)
        {
            
            return true;
        }
        return false;

    }
}
