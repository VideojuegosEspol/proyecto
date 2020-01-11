using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarTexto : MonoBehaviour
{
    public GameObject myObjects;
    public bool isMedallon;
    void Start(){
            myObjects.SetActive(false);        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player"){
                myObjects.SetActive(true);
            if(!isMedallon)
                Destroy(myObjects, 5f);
        }
    }
}
