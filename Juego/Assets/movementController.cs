using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementController : MonoBehaviour
{
    public Transform from;
    public Transform destine;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnDrawGizmosSelected()
    {
        if(from!=null && destine != null)
        {
            Gizmos.color = Color.cyan;
            Gizmos.DrawLine(from.position, destine.position);
            Gizmos.DrawSphere(from.position, 0.15f);
            Gizmos.DrawSphere(destine.position, 0.15f);
        }
    }
}
