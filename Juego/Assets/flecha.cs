using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flecha : MonoBehaviour
{
    public float speed = 15f;
    public Rigidbody2D rb;
    public GameObject impactEffect;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;

    }


    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Debug.Log(hitInfo.name);
        Instantiate(impactEffect, transform.position, transform.rotation);
        Destroy(gameObject);
        EnemyDead enemyDead = hitInfo.GetComponent<EnemyDead>();
        if (enemyDead != null)
        {
            enemyDead.Died();
        }

        if (hitInfo.tag == "Boss")
        {

            Boss boss = hitInfo.GetComponent<Boss>();

            if (boss.NoHealt())
            {
                boss.Died();
            }
            else
            {
                boss.TakeDamage(25);
            }

        }






    }
}
