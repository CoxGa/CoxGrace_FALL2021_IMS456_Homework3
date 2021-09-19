using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piece : MonoBehaviour
{
    [SerializeField]
    private Sprite blueColor;
    [SerializeField]
    private Sprite redColor;
    [SerializeField]
    private Sprite greenColor;
    [SerializeField]
    private Sprite purpleColor;
    [SerializeField]
    private Sprite goldColor;
    [SerializeField]
    private Sprite greyColor;
    [SerializeField]
    private Sprite brownColor;

    [SerializeField]
    private SpriteRenderer spriteRenderer;


    private void Awake()
    {
        ChooseColor();
    }

    private void ChooseColor()
    {
        //TODO
        // set spriteRenderer.sprite to a random sprite that is present above

        //spriteRenderer.sprite = ???;

        Sprite[] ArrayList = { blueColor, redColor, greenColor, purpleColor, goldColor, greyColor, brownColor }; //Made an array of the sprites

        spriteRenderer.sprite = ArrayList[Random()]; //Each time a piece spawns it will pick a random sprite from the array 
    }

    private int Random()
    {
        return UnityEngine.Random.Range(0,7);

    }

   


}
