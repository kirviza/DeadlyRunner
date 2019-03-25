using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingScript : MonoBehaviour {
	// Use this for initialization
	public float speed;
	public float size;
	private float leftBorder;
	private Vector3 pos;
	void Start () {
		leftBorder = Camera.main.ScreenToWorldPoint(new Vector2(0,0)).x;
		Debug.Log(leftBorder);
		size = GetComponent<SpriteRenderer>().bounds.extents.x*2;
		Debug.Log(GetComponent<SpriteRenderer>().bounds.max.x);
	}
	
	// Update is called once per frame
	void Update () {
		pos = transform.position;
		transform.position = new Vector3(pos.x - Time.deltaTime*speed,pos.y,pos.z);
		if (transform.position.x < leftBorder){
			transform.position = new Vector3(size*2f + leftBorder,pos.y,pos.z);
		}
	}
}
