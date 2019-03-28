using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManRun : MonoBehaviour {

	public float speed = 1.0f;
	public float distance = 20.0f;

	public bool manType;
	public int needDead = 0;

	public GameObject head;

	private Vector3 deathPosition;

	public GameObject Light;
	
	private GameObject mainLight;


	void Start()
	{
		/* 
		switch(Camera.main.GetComponent<CreateMans>().whoNeedKill)
		{
			case 1:needDead = Random.Range(0, 100)%2; break;
			case 2:needDead = manType ? 1 : 0; break;
			case 3:needDead = manType ? 0 : 1; break;
			case 4:needDead = 1; break;
			case 5:needDead = Random.Range(0, 100)%2; break;
		}
		*/

		deathPosition = GameObject.FindGameObjectWithTag("Death").transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(transform.position.x - Time.deltaTime * speed, transform.position.y, transform.position.z);
		if(needDead == 1 && !mainLight)
		{
			if(Vector2.Distance(transform.position, deathPosition) < distance)
			{
				mainLight = Instantiate(Light, Vector3.zero, Quaternion.identity) as GameObject;
				mainLight.transform.parent = transform;
				mainLight.transform.localScale = new Vector3(1, 1, 1);
				mainLight.transform.localPosition = Vector3.zero;
			}
		}
		if(transform.position.x < -25.0f)
		    Destroy(gameObject);
	}
}
