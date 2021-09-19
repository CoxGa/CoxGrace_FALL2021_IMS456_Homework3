using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounds : MonoBehaviour
{
    [SerializeField]
    private GameObject ballPrefab = null;
    Vector3 PaddlePos;

    private bool ballPlay = true;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //TODO: Implement functionality to reset the game somehow.
        // Resetting the game includes destroying the out of bounds ball and creating a new one ready to be launched from the paddle
    }

    // Start is called before the first frame update
    void Start()
    {

        PaddlePos = GameObject.FindGameObjectWithTag("Player").transform.position;

        Instantiate(ballPrefab, new Vector3(PaddlePos.x, -3.13f, 0), Quaternion.identity); //Creates the ball at the x position of the paddle
       

    }

    // Update is called once per frame
    void Update()
    {

        if (!ballPlay) //if the ball has died
        {
            
            
            
                PaddlePos = GameObject.FindGameObjectWithTag("Player").transform.position;

                Instantiate(ballPrefab, new Vector3(PaddlePos.x, -3.13f, 0), Quaternion.identity);//then create new ball at the paddle
                
                ballPlay = true;//ball is now in play
            

        }

    }

    void OnCollisionEnter2D(Collision2D collision)
    {

        Debug.Log("OUT OF BOUNRDS!!!");

        if (collision.gameObject.CompareTag("Ball"))
        {
            Destroy(collision.gameObject);

            ballPlay = false;//Ballis now dead
        }


    }
}
