using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlappyBird_TriggerScript : MonoBehaviour
{
    //Variables & References 
    public FlappyBird_LogicScript logic;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Boundary").GetComponent<FlappyBird_LogicScript>(); //in order to find tagged game object and utilize its script
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision) //function to make use of trigger inbewteen pipes
    {
        if(collision.gameObject.layer == 6) //clause to proof it is the bird that activates trigger instead of other game objects
        {
            logic.addScore(1); //adds score once trigger is activated
        }
    }
}
