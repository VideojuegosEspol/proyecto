using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TornadoCollision : MonoBehaviour
{
    public float empujeSuperior;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            SoundManager.PlaySound("Tornado");
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, empujeSuperior));
        }
    }
}
