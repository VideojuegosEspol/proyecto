using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2Beha : MonoBehaviour
{
    public Transform player;
    public Animator animacion;

    // Update is called once per frame
    void Update()
    {
        Vector2 direction = player.position - transform.position;
        Debug.Log(direction.x);
        //animacion.SetTrigger("Attack");
        if (direction.x > -2.5)
        {
            animacion.SetTrigger("Attack");
            //Debug.Log("Funciona");
        }

    }
}
