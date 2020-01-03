using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarLava : MonoBehaviour
{
    public GameObject[] myObjects;
    public bool activo;
    //private Boss boss;

    // Start is called before the first frame update
    void Start()
    {
        
        foreach (GameObject m in myObjects)
        {
            m.SetActive(activo);            
        }

        //boss = GameObject.FindGameObjectWithTag("Boss").GetComponent<Boss>();

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            foreach (GameObject m in myObjects)
            {
                m.SetActive(true);
            }

            /*if (boss.health <= 0) {
                foreach (GameObject m in myObjects)
                {
                    m.SetActive(false);
                }
            }*/
        }

        

        /*if (BossFuego.Vida <= 0)
        {
            foreach (GameObject m in myObjects)
            {
                m.SetActive(false);
            }
        }*/
    }

    
}
