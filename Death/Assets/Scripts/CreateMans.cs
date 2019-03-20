using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateMans : MonoBehaviour {

	public Transform parent;
	public float minTime = 1f;
	public float maxTime = 2f;
	public GameObject goodMan;
	public GameObject badMan;

	public bool needCreate = false;

	public int whoNeedKill = 0;

	private float deltaTime = 0f;
	private float mainTime;
	private int typeMan;

	void Start () {
		needCreate = false;
		mainTime = maxTime;
		deltaTime = 0;
	}
	void Update () {
		if(needCreate)
		{
			deltaTime += Time.deltaTime;
			if(deltaTime>mainTime)
			{
				gameObject.GetComponent<ScoreScript>().stateStart = true;
				gameObject.GetComponent<health>().stateStart = true;
				
				mainTime = Random.Range(minTime, maxTime);
				deltaTime = 0;
				typeMan = Random.Range(0, 100);
				
				if(typeMan%2 == 1)
					Instantiate(goodMan, new Vector3(25, -1.0f, 0), Quaternion.identity, parent);
				else
					Instantiate(badMan, new Vector3(25, -1.0f, 0), Quaternion.identity, parent);
			}
		}
	}
	
}
