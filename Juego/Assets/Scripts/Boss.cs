using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Boss : MonoBehaviour
{
    public int health;
    public int damage;
    private float timeBtwDamage = 1.5f;

    //public Animator redPanel;
    //public Animator camAnim;
    public Slider healthBar;

    private void Update()
    {
        if (timeBtwDamage > 0)
        {
            timeBtwDamage -= Time.deltaTime;
        }
        healthBar.value = health;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            health -= 5;
        }
        if (health <= 0)
        {
            SoundManager.PlaySound("MuerteBoss");
            transform.parent.gameObject.SetActive(false);
            Destroy(this.gameObject);
        }
    }

}
