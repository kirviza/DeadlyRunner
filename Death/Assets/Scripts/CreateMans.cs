using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateMans : MonoBehaviour {

	public float minTime = 1f;
	public float maxTime = 2f;
	public GameObject goodMan;
	public GameObject badMan;

	private float deltaTime = 0f;
	private float mainTime;
	private int typeMan;

	void Start () {
		mainTime = maxTime;
	}
	void Update () {
		deltaTime += Time.deltaTime;
		if(deltaTime>mainTime)
		{
			gameObject.GetComponent<ScoreScript>().stateStart = true;
			
			mainTime = Random.Range(minTime, maxTime);
			deltaTime = 0;
			typeMan = Random.Range(0, 100);
			
			if(typeMan%2 == 1)
				Instantiate(goodMan, new Vector3(10, -2.54f, 0), Quaternion.identity);
			else
				Instantiate(badMan, new Vector3(10, -2.54f, 0), Quaternion.identity);
		}
	}
}
