using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBlocks : MonoBehaviour {

    public GameObject EnemyCube;
    public GameObject PointSphere;
    public float spawnSpeed;


    void Spawn()
    {
        // Get a random X coordinate to spawn the enemy block.
        int randX = Random.Range(0, Camera.main.pixelWidth);

        // Set this block's Y coordinate to the height of the screen.
        int y = Camera.main.pixelHeight;

        // Here's our target position.
        Vector3 Target = Camera.main.ScreenToWorldPoint(new Vector3(randX, y, 0));
        Target.z = 0;

        // Get a random number to determine whether it's a point sphere
        // spawning or an enemy block spawning.
        int randNum = Random.Range(1, 5);

        if (randNum == 1)
        {
            // Create a point sphere.
            Instantiate(PointSphere, Target, Quaternion.identity);
        } else
        {
            // Create an enemy block.
            Instantiate(EnemyCube, Target, Quaternion.identity);
        }

        
        
    }

	// Use this for initialization
	void Start () {
        InvokeRepeating("Spawn", 0f, spawnSpeed);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
