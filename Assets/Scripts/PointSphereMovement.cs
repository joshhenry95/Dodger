using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointSphereMovement : MonoBehaviour
{

    public float sphereFallingSpeed;
    public GameObject PointSphere;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0f, -sphereFallingSpeed, 0f);

        if (transform.position.y < -5f)
        {
            Destroy(PointSphere);
        }
    }
}