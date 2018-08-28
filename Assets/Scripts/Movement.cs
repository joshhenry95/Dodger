using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public float movementSpeed;
    //float mouseLocation;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {

        Vector3 target = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        target.z = transform.position.z;

        transform.position = Vector3.MoveTowards(transform.position, target, movementSpeed * Time.deltaTime);


	}
}
