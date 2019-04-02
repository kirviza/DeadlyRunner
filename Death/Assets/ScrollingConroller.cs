using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingConroller : MonoBehaviour {
	public GameObject[] items;
	public float speed;
	public float size;
	private GameObject temp;
	private float leftBorder;
	private Vector3 posLeft,posRight;
	// Use this for initialization
	void Start () {
		leftBorder = Camera.main.ScreenToWorldPoint(new Vector2(0,0)).x;
		size = GetComponentInChildren<SpriteRenderer>().bounds.extents.x*2;
	}
	
	// Update is called once per frame
	void Update () {
		foreach (var item in items)
		{
			item.transform.position = new Vector3(item.transform.position.x - Time.deltaTime*speed,item.transform.position.y,item.transform.position.z);
		}
		posLeft = items[0].transform.position;
		posRight = items[1].transform.position;
		if (posLeft.x<leftBorder){
			items[0].transform.position = new Vector3(posRight.x+size,posLeft.y,posLeft.z);
			temp = items[0];
			items[0] = items[1];
			items[1] = temp;
		}
		// pos = transform.position;
		// transform.position = new Vector3(pos.x - Time.deltaTime*speed,pos.y,pos.z);
		// if (transform.position.x < leftBorder){
		// 	transform.position = new Vector3(size + 14f,pos.y,pos.z);
		// }
	}
}
