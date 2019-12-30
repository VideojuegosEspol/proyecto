using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossFuego : MonoBehaviour
{
    [SerializeField]
    public static float Vida;
    float dirX;
    [SerializeField]
    public float moveSpeed; //Vlocidad del Boss
    Rigidbody2D rB;
    bool facingRight = false;
    Vector3 localScale;

    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        localScale = transform.localScale;
        rB = GetComponent<Rigidbody2D>();
        dirX = -1f;

        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    /*void Update()
    {
        if (transform.position.x < -9f)
            dirX = 1f;
        else if (transform.position.x > 9f)
            dirX = -1f;
        anim.SetBool("isWalking", true);

    }
    private void FixedUpdate()
    {
        rB.velocity = new Vector2(dirX * moveSpeed, rB.velocity.y);
    }

    private void LateUpdate()
    {
        CheckWhereToFace();
    }

    void CheckWhereToFace()
    {
        if (dirX > 0)
            facingRight = true;
        else if (dirX < 0)
            facingRight = false;
        if (((facingRight) && (localScale.x < 0)) || ((!facingRight) && (localScale.x > 0)))
            localScale.x *= -1;
        
        transform.localScale = localScale;
    }*/

}
