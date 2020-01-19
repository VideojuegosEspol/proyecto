using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour
{
    private static GameMaster instance;
    public Vector2 lastCheckPoint;

    void Awake()
    {
        if (instance == null){
            instance = this;
            DontDestroyOnLoad(instance); //Ayuda a no reestablecer toda la info almacenada del juego            
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
