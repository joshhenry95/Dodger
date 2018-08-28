using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockMovement : MonoBehaviour
{

    public float blockFallingSpeed;
    public GameObject EnemyCube;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0f, -blockFallingSpeed, 0f);

        if (transform.position.y < -5f)
        {
            Destroy(EnemyCube);
        }
    }
}