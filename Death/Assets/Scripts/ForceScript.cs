using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceScript : MonoBehaviour {
	private bool useForce = true;
	private float timeLife = 0.0f;
	private const float maxTimeLife = 3.0f;

	private float speed = 300.0f;

	private Transform body;


	// Use this for initialization
	void Start () {
		speed = Random.Range(250.0f, 350.0f);
	}
	
	// Update is called once per frame
	void Update () {
		if(useForce)
		{
			GetComponent<Animator>().enabled = false;
			GetComponent<SpriteRenderer>().sprite = GetComponent<HeadsMain>().rip;
			GetComponent<Collider2D>().enabled = false;
			body = transform.parent;
			transform.parent = null;
			Destroy(body.gameObject);
			GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
			GetComponent<Rigidbody2D>().AddForce(new Vector2(1.0f, Random.Range(0.5f, 1.0f)) * Random.Range(10.0f, 20.0f), ForceMode2D.Impulse);
			useForce = !useForce;
		}

		transform.Rotate(0.0f, 0.0f, speed * Time.deltaTime);



		if(transform.parent == null)
		{
			timeLife += Time.deltaTime;
		}

		if(timeLife>maxTimeLife)
			Destroy(gameObject);
	}
}
 