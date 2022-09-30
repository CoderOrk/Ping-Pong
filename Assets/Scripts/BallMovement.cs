using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    [SerializeField] float moveSpeedX = 7f;
    [SerializeField] float moveSpeedY = 0;

    Rigidbody2D myRigidbody2D;

    void Start()
    {
        myRigidbody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        myRigidbody2D.velocity = new Vector2(moveSpeedX, 0f);
    }

    void OnCollisionEnter2D(Collision2D other) 
    {
        moveSpeedX = -moveSpeedX;

        if(other.rigidbody != null)
        {
            moveSpeedY = other.rigidbody.velocity.y;
        }
        //increment score
    }
}
