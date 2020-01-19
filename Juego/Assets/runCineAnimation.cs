using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class runCineAnimation : MonoBehaviour
{
    public Transform target;

    public float speed;
    private Vector3 start, end;


    public float timeStart;
    public float endTime;
    bool timerActive = true;


    // Start is called before the first frame update
    void Start()
    {
        if (target != null)
        {
            target.parent = null;
            start = transform.position;
            end = target.position;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    void FixedUpdate()
    {
        timeStart += Time.deltaTime;
        if (timeStart >= endTime)
        {
            timerActive = false;
            if (target != null)
            {
                float fixedSpeed = speed * Time.deltaTime;
                transform.position = Vector3.MoveTowards(transform.position, target.position, fixedSpeed);
            }
        }
    }
}