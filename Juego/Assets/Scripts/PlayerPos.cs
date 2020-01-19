using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerPos : MonoBehaviour
{
    private GameMaster gm;

    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
        transform.position = gm.lastCheckPoint;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Abismo")
        {
            
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    // Update is called once per frame
    /*void Update()
    {
        //Aqui debe entrar un if cuando el player muera para cargar CheckPoint
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }*/
}
