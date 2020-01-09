using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmpujeLava : MonoBehaviour
{
    public float empujeX;
    public float empujeY;
    public float damage;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            SoundManager.PlaySound("lava");
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(empujeX, empujeY));

            PlayerMovement playerMovement = collision.GetComponent<PlayerMovement>();
            StartCoroutine(playerMovement.hurtAnimation());
            PlayerMovement.life -= damage;
            Debug.Log(PlayerMovement.life);
            HealthBar.Heath = PlayerMovement.life;
            PlayerMovement.evaluate();
        }
    }
}
