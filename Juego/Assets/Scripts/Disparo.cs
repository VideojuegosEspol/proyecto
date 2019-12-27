using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
    public float moveSpeed;
    Rigidbody2D rB;
    public float damage; //Daño que recibe el jugador.
    //Player target; //Este debe ser el objeto Ninja del juego
    Vector2 moveDirection;
    
    // Start is called before the first frame update
    void Start()
    {
        rB = GetComponent<Rigidbody2D>();
        //target = GameObject.FindObjectOfType<Player>();
        //moveDirection = (target.transform.position - transform.position).normalized * moveSpeed;
        rB.velocity = new Vector2(moveDirection.x, moveDirection.y);
        Destroy(gameObject, 3f);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name.Equals("Player"))
        {
            //PlayerLife.life -=damage;
            Destroy(gameObject);

        }
    }
}
