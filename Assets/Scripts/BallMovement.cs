using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    [SerializeField] float moveSpeedX = -7f;
    [SerializeField] float moveSpeedY = 0f;
    [SerializeField] float moveSpeedIncrease = 0.25f;

    Rigidbody2D myRigidbody2D;
    ScoreKeeper scoreKeeper;
    GameManager gameManager;

    void Start()
    {
        myRigidbody2D = GetComponent<Rigidbody2D>();
        scoreKeeper = FindObjectOfType<ScoreKeeper>();
        gameManager = FindObjectOfType<GameManager>();

        SeverBall();
    }

    void SeverBall()
    {
        myRigidbody2D.velocity = new Vector2(moveSpeedX, 0f);

    }

    void OnCollisionEnter2D(Collision2D other) 
    {
        if(other.gameObject.tag == "Right Goal")
        {
            scoreKeeper.IncreaseScore();
            moveSpeedX += moveSpeedIncrease;
        }
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.tag == "Left Goal")
        {
            Destroy(gameObject);
            Debug.Log("You Lose");
            gameManager.ReloadScene();
        }  
    }
}
