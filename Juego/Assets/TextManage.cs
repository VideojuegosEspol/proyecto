using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManage : MonoBehaviour
{
    // Start is called before the first frame update
   
    public Text textfield;
    public string frase;
    
    //public GameObject a;

    void OnTriggerEnter2D(Collider2D collision){

        if(collision.tag == "Player"){
            textfield.text = frase;    
        }
        


    }











}
