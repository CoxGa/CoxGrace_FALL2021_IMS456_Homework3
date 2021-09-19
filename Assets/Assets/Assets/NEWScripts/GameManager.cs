using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public const float ROW_HEIGHT = 0.48f;
    public const int PIECE_COUNT_PER_ROW = 13;
    public const float PIECE_LENGTH = 0.96f;
    public const int TOTAL_ROWS = 10;

    [SerializeField]
    private Transform pieces = null;
    

    [SerializeField]
    private GameObject piecePrefab = null;

    [SerializeField]
    private EdgeCollider2D border;

    private GameObject ballPrefab = null;

    private bool ballPlay = false;

    //TODO
    //Using const data defined above "Instantiate" new pieces to fill the view with

    // Start is called before the first frame update
    void Start()
    {

        for (int i = 0; i < PIECE_COUNT_PER_ROW; ++i)
        {
            Instantiate(piecePrefab, new Vector3(-6 + i, 4, 0), Quaternion.identity); //+i adds the row of 13 pieces
            Instantiate(piecePrefab, new Vector3(-6 + i, 3.6f, 0), Quaternion.identity); //I couldnt get it to work for the collums so yeah
            Instantiate(piecePrefab, new Vector3(-6 + i, 3, 0), Quaternion.identity);
            Instantiate(piecePrefab, new Vector3(-6 + i, 2.6f, 0), Quaternion.identity);
            Instantiate(piecePrefab, new Vector3(-6 + i, 2, 0), Quaternion.identity);
            Instantiate(piecePrefab, new Vector3(-6 + i, 1.6f, 0), Quaternion.identity);
            Instantiate(piecePrefab, new Vector3(-6 + i, 1, 0), Quaternion.identity);
            Instantiate(piecePrefab, new Vector3(-6 + i, .6f, 0), Quaternion.identity);
            Instantiate(piecePrefab, new Vector3(-6 + i, 0, 0), Quaternion.identity);
            Instantiate(piecePrefab, new Vector3(-6 + i, -.6f, 0), Quaternion.identity);
        }

    }

    // Update is called once per frame
    void Update()
    {


    }
}
