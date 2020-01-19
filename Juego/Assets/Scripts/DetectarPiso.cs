using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectarPiso : MonoBehaviour
{

    public float speed; //Velocidad del personaje
    public float distance; 

    private bool movingLeft = true; //Direccion del personaje
    public Transform groundDetection;
    public bool frentePersonaje; //True si direccion de coordenada es positiva


    // Update is called once per frame
    void Update()
    {
        if (frentePersonaje)
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
        RaycastHit2D groundInfo = Physics2D.Raycast(groundDetection.position, Vector2.down, distance);
        if (groundInfo.collider == false)
        {
            if (movingLeft == true)
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                movingLeft = false;
            }
            else
            {
                transform.eulerAngles = new Vector3(0, -180, 0);
                movingLeft = true;
            }
        }

    }
}
