using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RipRun : MonoBehaviour {

	// Use this for initialization
	public float speed = 1.0f;
	
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		transform.position = new Vector3(transform.position.x - Time.deltaTime * speed, transform.position.y, transform.position.z);

		if(transform.position.x < -25.0f)
		{
		    Destroy(gameObject);
		}
		
	}
}
