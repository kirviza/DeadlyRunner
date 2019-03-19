using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour {
	public float backgroundSpeed = 10f;
	public GameObject[] screens = new GameObject[2];
	public float whide = 60f;
	// Use this for initialization
	public float xLeft;
	void Start () {
		xLeft = screens[0].transform.position.x;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(transform.position.x - Time.deltaTime * backgroundSpeed, transform.position.y, transform.position.z);
		xLeft = screens[0].transform.position.x;
		if(xLeft < -60f)
		{
			screens[0].transform.position = new Vector3(screens[1].transform.position.x + whide,screens[1].transform.position.y,screens[1].transform.position.z);
			GameObject temp = screens[1];
			screens[1] = screens[0];
			screens[0] = temp;
		}


	}
}
