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
    public int x;
    // Start is called before the first frame update
    void Start()
    {
        rB = GetComponent<Rigidbody2D>();
        //target = GameObject.FindFindObjectOfType<Player>();
        moveDirection = new Vector2(x, 0.0f)* moveSpeed;
        rB.velocity = new Vector2(moveDirection.x, moveDirection.y);
        Destroy(gameObject, 1f);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player")){
            //PlayerLife.life -=damage;
            PlayerMovement.life -= damage;
            Debug.Log(PlayerMovement.life);
            HealthBar.Heath = PlayerMovement.life / 3;
            Destroy(this.gameObject);
            PlayerMovement.evaluate();
            SoundManager.PlaySound("classic_hurt");

            /*PlayerMovement.life-= damage;
            Destroy(this.gameObject);
            PlayerMovement.evaluate();*/

        }
    }
}
