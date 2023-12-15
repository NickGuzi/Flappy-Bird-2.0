using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlappyBird_BirdScript : MonoBehaviour
{
    //Variables & References 
    public Rigidbody2D myRigidbody;
    public float flapStrength; //Bird Velocity Modifier
    public FlappyBird_LogicScript logic;
    public bool birdIsAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Boundary").GetComponent<FlappyBird_LogicScript>(); //in order to find tagged game object and utilize its script
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive == true) // if player presses space and game is not over then velocity is added to bird upwards
        {
            myRigidbody.velocity = Vector2.up * flapStrength;
        }
        if (transform.position.y > 18 || transform.position.y < -18) //Ends game if bird goes off screen
        {
            logic.gameOver();
            birdIsAlive = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) // function that loads game over screen and controls bird physics when bird crashes into pipe 
    {
        logic.gameOver();
        birdIsAlive = false;
    }
}
