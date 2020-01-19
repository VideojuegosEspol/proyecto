using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarTexto : MonoBehaviour
{
    public GameObject myObjects;
    public bool isMedallon;
    public bool isPergamino;
    void Start(){
            myObjects.SetActive(false);        
    }

    void Update()
    {
        if (isPergamino)
        {
            if (Input.GetKeyDown(KeyCode.X)){
                myObjects.SetActive(false);
            }
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player"){
                myObjects.SetActive(true);
            if (isPergamino)
            {
                SoundManager.PlaySound("Lectura");                
            }
            else if (!isMedallon)
                Destroy(myObjects, 5f);
        }
    }

    
}
