using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float groundSPD = 5;

    private SpriteRenderer mySpriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        mySpriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //When the D key is pressed the player faces right
        //When the button is held the player moves to the right
        if (Input.GetKeyDown(KeyCode.D))
        {
            mySpriteRenderer.flipX = false;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * groundSPD * Time.deltaTime);
        }


        //When the D key is pressed the player faces left
        //When the button is held the player moves to the left
        if (Input.GetKeyDown(KeyCode.A))
        {
            mySpriteRenderer.flipX = true;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.left * groundSPD * Time.deltaTime);
        }
    }

   
}
