using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    [SerializeField] float startingSpeed = 5f;
    [SerializeField] float maxSpeed = 40f;
    [SerializeField] float moveSpeed = 5f;
    [SerializeField] float moveSpeedIncrease = 1.25f;

    Rigidbody2D myRigidbody2D;
    ScoreKeeper scoreKeeper;
    GameManager gameManager;

    void Start()
    {
        myRigidbody2D = GetComponent<Rigidbody2D>();
        scoreKeeper = FindObjectOfType<ScoreKeeper>();
        gameManager = FindObjectOfType<GameManager>();

        SeverBall(-moveSpeed, Random.value * moveSpeed);
    }

    void SeverBall(float x, float y)
    {
        myRigidbody2D.velocity = new Vector2(x, y);

    }

    void OnCollisionEnter2D(Collision2D other) 
    {
        if(other.gameObject.tag == "Right Goal" && scoreKeeper != null)
        {
            scoreKeeper.IncreaseScore();

            float signOfX = Mathf.Sign(myRigidbody2D.velocity.x);
            moveSpeed *= moveSpeedIncrease * signOfX;

            if(Mathf.Abs(moveSpeed) > maxSpeed)
            {
                moveSpeed = maxSpeed * signOfX;
            }
            
            Debug.Log("Ball Speed: " + moveSpeed);
            myRigidbody2D.velocity = new Vector2(moveSpeed, myRigidbody2D.velocity.y);
        }
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.tag == "Left Goal")
        {
            Destroy(gameObject);
            Debug.Log("You Lose");
            gameManager.LoadMenu();
        }  
    }
}
