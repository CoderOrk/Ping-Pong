using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    [SerializeField] float moveSpeed = 7f;

    Rigidbody2D myRigidbody2D;

    void Start()
    {
        myRigidbody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        myRigidbody2D.velocity += new Vector2(moveSpeed, 0);
    }

    void OnCollisionEnter(Collision other) 
    {
        
    }
}
