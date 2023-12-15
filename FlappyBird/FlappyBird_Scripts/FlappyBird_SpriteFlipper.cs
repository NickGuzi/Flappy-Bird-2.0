using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlappyBird_SpriteFlipper : MonoBehaviour
{
    //Variables & References 
    private SpriteRenderer myRenderer;
    public AudioSource flapSFX;

    // Start is called before the first frame update
    private void Start()
    {
        myRenderer = GetComponent<SpriteRenderer>();
        flapSFX = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    private void Update()
    {
        //If the Space key is presses
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //If the variable isn't empty
            if(myRenderer != null)
            {
                //Flip the sprite 
                myRenderer.flipY = true;
                flapSFX.Play(); //plays flap noise whenever space button pressed
            }
        }
        else if (Input.GetKeyUp(KeyCode.Space)) // If the space key is released 
        {
            //If the variable isn't empty
            if (myRenderer != null)
            {
                //Flip the sprite 
                myRenderer.flipY = false;
            }
        }
    }
}
