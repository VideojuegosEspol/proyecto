using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{

    private GameMaster gm;

    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>(); 
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) //Se activa el CheckPoint si colisiona con el jugador
        {
            SoundManager.PlaySound("Save");
            gm.lastCheckPoint = transform.position;
        }
    }

    //https://www.youtube.com/watch?v=ofCLJsSUom0&list=WL&index=2&t=0s
}
