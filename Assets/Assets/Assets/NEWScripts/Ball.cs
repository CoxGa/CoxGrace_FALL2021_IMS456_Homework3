using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D rigidBody = null;
    
    [SerializeField]
    private GameObject Paddle = null;

    //TODO: Add code to move ball along with code to delete pieces upon colliding with one
    //Ball should only move once its been launched
    
    float speed = 3.0f;
    private Vector3 currentDirection = Vector3.zero;
    Vector3 PaddlePos;
    bool BallStart = false;

   

void OnAwake()
    {
        
        transform.Translate(-0.02f,-3.13f,0);
    }

    // Start is called before the first frame update
    void Start()
    {
        currentDirection = new Vector3(Random(), Random(), 0);
        transform.Translate(PaddlePos.x, 0.5f, -3.13f, 0); //Ball starts at this position just in case other code doesnt work
    }

    // Update is called once per frame
    void Update()
    {

        if (!BallStart) //if the ball has not been launched then stay still and follow the paddle
        {

            PaddlePos = GameObject.FindGameObjectWithTag("Player").transform.position;
            transform.position = new Vector3(PaddlePos.x, -3.13f, 0);
        }




        if (Input.GetKey(KeyCode.Space)) //pressed key to launch bal;
        {
            BallStart = true;//ball is launched
        }
        
        if (BallStart)
        {

            var newDelta = currentDirection * Time.deltaTime * speed;


            rigidBody.MovePosition(transform.position + newDelta);//ball will now move
        
        }

        }

    void OnCollisionEnter2D(Collision2D collider)
    {

        currentDirection = Vector2.Reflect(currentDirection, collider.contacts[0].normal);//bounce in oposite direction

        speed = 5.0f;

        Debug.Log("COLLISION!!!!!!");

    

        if (collider.gameObject.CompareTag("Piece"))
        {
            Destroy(collider.gameObject);//desroy bricks
            
        }

        if (collider.gameObject.CompareTag("Bounds"))
        {
            BallStart = false;//ball is now not in play can will go back to the paddle 
        }


       }
    private int Random()
    {

        return UnityEngine.Random.Range(1,2);
    
    }

}
