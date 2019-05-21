using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateMans : MonoBehaviour {

	public Transform parent;
	public float minTime = 1f;
	public float maxTime = 2f;
	public GameObject[] men;

	private int numbMan = 0;
	private float deltaTime = 0;
	private float mainTime = 0;

	void Start () {
		deltaTime = 0;
		mainTime = 0;
	}
	
	void Update () {
		if(GetComponent<GameProperty>()._NeedCreateMan &&  GetComponent<GameProperty>()._CurScore != 0 && !GetComponent<GameProperty>()._PauseGame)
		{
			deltaTime += Time.deltaTime;
			if(deltaTime>mainTime)
			{	
				mainTime = Random.Range(minTime, maxTime);
				deltaTime = 0;
				numbMan = Random.Range(0, men.Length);	

				GameObject man = Instantiate(men[numbMan], new Vector3(25, -1.0f, 0), Quaternion.identity, parent) as GameObject;
 
 
				man.GetComponent<ManRun>().manType = (MAN_TYPE) Random.Range(0, 3);
			}
		}
	}
	
}
