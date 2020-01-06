using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterEnemyDead : MonoBehaviour
{
    public int health;
    public int damage;
    private float timeBtwDamage = 1.5f;

    
    public Animator animacion;
    

    private void Update()
    {
        if (timeBtwDamage > 0)
        {
            timeBtwDamage -= Time.deltaTime;
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Sword"))
        {
            TakeDamage(5);
        }
        if (health <= 0)
        {
            animacion.SetTrigger("Dead");
            Died();
        }
    }

    public void TakeDamage(int lessdamage)
    {
        health -= lessdamage;
    }

    public void Died()
    {

        SoundManager.PlaySound("Aplastar");
        transform.parent.gameObject.SetActive(false);
        Destroy(this.gameObject);

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
