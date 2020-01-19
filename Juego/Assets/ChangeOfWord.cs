using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeOfWord : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player" && SceneManager.GetActiveScene().name == "WaterWorld")
        {
            SceneManager.LoadScene("AirWorld", LoadSceneMode.Single);

        }
        else if (other.gameObject.tag == "Player" && SceneManager.GetActiveScene().name == "IntroWorld")
        {
            SceneManager.LoadScene("WaterWorld", LoadSceneMode.Single);

        }
        else if (other.gameObject.tag == "Player" && SceneManager.GetActiveScene().name == "AirWorld")
        {
            SceneManager.LoadScene("Creditos", LoadSceneMode.Single);

        }
    }
}
