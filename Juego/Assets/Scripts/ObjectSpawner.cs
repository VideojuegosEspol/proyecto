using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour{
	public GameObject objecto;
	Vector2 whereToSpawn;
	public float spamnRate = 2f;
	float nextSpamn = 0.0f;

    void Start()
    {
        
    }
    void Update(){
		if(Time.time > nextSpamn){
			nextSpamn = Time.time + spamnRate;
			whereToSpawn = new Vector2(transform.position.x, transform.position.y);
			Instantiate(objecto, whereToSpawn, Quaternion.identity);
        }
	}
}