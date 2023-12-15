using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlappyBird_PipeMove : MonoBehaviour
{
    //Variables & References 
    public float moveSpeed = 5;
    public float deadZone = -45;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3.left * moveSpeed) * Time.deltaTime; // Moves pipes across screen based on Time.DeltaTime

        if(transform.position.x < deadZone)//if statement to delete pipes that have passed screen
        {
            Debug.Log("Pipe Deleted"); // Log for pipe deletions
            Destroy(gameObject);
        }
    }
}
