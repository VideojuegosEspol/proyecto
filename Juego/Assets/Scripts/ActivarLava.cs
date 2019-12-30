using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarLava : MonoBehaviour
{
    public GameObject[] myObjects;
    public bool activo;
    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject m in myObjects)
        {
            m.SetActive(activo);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            foreach (GameObject m in myObjects)
            {
                m.SetActive(true);
            }
                
        }

        /*if (BossFuego.Vida <= 0)
        {
            foreach (GameObject m in myObjects)
            {
                m.SetActive(false);
            }
        }*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
