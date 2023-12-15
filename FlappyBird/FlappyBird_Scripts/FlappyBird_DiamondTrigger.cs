using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlappyBird_DiamondTrigger : MonoBehaviour
{
    //Variables & References
    public FlappyBird_LogicScript logic;
    public AudioSource collectSFX;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Boundary").GetComponent<FlappyBird_LogicScript>(); //in order to find tagged game object and utilize its script
        collectSFX = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision) //function to make use of bird impact on diamond
    {
        if (collision.gameObject.layer == 6) //clause to proof it is the bird that activates trigger instead of other game objects
        {
            collectSFX.Play();
            logic.addScore(5); //adds score once trigger is activated
            Destroy(gameObject, collectSFX.clip.length);
        }
    }
}
