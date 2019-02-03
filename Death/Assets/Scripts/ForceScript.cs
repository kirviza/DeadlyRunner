using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceScript : MonoBehaviour {

	private bool useForce = true;
	private float timeLife = 0.0f;
	private const float maxTimeLife = 3.0f;


	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if(useForce)
		{
			transform.parent = null;
			GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
			GetComponent<Rigidbody2D>().AddForce(new Vector2(1.0f, Random.Range(0.0f, 1.0f)) * Random.Range(10.0f, 20.0f), ForceMode2D.Impulse);
			useForce = !useForce;
		}

		if(transform.parent == null)
		{
			timeLife += Time.deltaTime;
		}

		if(timeLife>maxTimeLife)
			Destroy(gameObject);
	}
}
