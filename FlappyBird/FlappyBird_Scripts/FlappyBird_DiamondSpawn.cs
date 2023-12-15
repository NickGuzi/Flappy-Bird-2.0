using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlappyBird_DiamondSpawn : MonoBehaviour
{
    //Variables & References
    public GameObject diamond;
    public float diamondSpawnRate; //how often pipe prefab spawns on screen
    private float timer = 0; //time placeholder
    public float heightOffset;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < diamondSpawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnDiamond();
            timer = 0;
        }

    }
    void spawnDiamond() // function to spawn pipes at random points 
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        Instantiate(diamond, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation); //Called using Unity object spawn function
    }
}
