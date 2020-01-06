using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BehaviourEW : MonoBehaviour

{
    public Transform player;
    public Animator animacion;

    // Update is called once per frame
    void Update()
    {

        Vector2 direction = player.position - transform.position;
       // animacion.SetTrigger("Walk");
        //Debug.Log(direction.x);
        //animacion.SetTrigger("Attack"); 
        if (  Mathf.Abs(direction.x) < 2)
        {
            
            animacion.SetTrigger("Attack");
            //Debug.Log("Funciona");
        }
        else
        {
            //Debug.Log("caminar");
            animacion.SetTrigger("Walk");
        }
        
        //Debug.Log(direction.x);
    }
}
