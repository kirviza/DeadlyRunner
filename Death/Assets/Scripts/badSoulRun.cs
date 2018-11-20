using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class badSoulRun : MonoBehaviour {
	private const float height = -10.0f;
	public float speed = 3f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(transform.position.x, transform.position.y - Time.deltaTime * speed, transform.position.z);

		if(transform.position.y < height)
		    Destroy(gameObject);
		
	}
}
