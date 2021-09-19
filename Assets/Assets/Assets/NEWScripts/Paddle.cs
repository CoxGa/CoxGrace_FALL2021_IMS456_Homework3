using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    //TODO
    // Move paddle left and right using keyboard keys, mapping is up to you
    // Paddle should be able to launch the ball upon space bar being pressed
    // A launched ball will then bounce around, changing its direction upon any collision

    float speed = 5.0f;
    Vector3 screenRight = new Vector3 (7,-3.34f,0);

    Vector3 screenLeft = new Vector3(-7, -3.34f, 0);

    public bool GameStart = false;
    public bool Bounds = true;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Move left and right ONLY

        if (Bounds)
        {


            if (Input.GetKey(KeyCode.RightArrow))
            {

                transform.Translate(Vector3.right * Time.deltaTime * speed, Space.World);

            }

            if (Input.GetKey(KeyCode.LeftArrow))
            {

                transform.Translate(Vector3.left * Time.deltaTime * speed, Space.World);


            }
        }

        //Out of bounds

        //if hit bounds stop moving an activate bounds code
        if (transform.position.x < -7)
        {
            Bounds = false;
        }
        if (transform.position.x > 7)
        {
            Bounds = false;
        }

        //if hit wall then move position back to the wall edge and turn off bounds so you can move again
        if (!Bounds)
        {

            if (transform.position.x < -7)
            {
                transform.position = new Vector3(-7f, -3.61f, 0);
            }

            if (transform.position.x > 7)
            {
                transform.position = new Vector3(7f, -3.61f, 0);
            }

            Bounds = true;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameStart = true;
        }

    }
}
