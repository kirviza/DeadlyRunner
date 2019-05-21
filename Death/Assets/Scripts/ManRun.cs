using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum MAN_TYPE {TYPE_ZERO, TYPE_GOOD, TYPE_BAD};

public class ManRun : MonoBehaviour {
	public float speed = 1.0f;
	public float distance = 20.0f;

	public MAN_TYPE manType;

	public GameObject[] masLight;

	public bool manState;

	private GameObject manLight;

	private Vector3 deathPosition;

	public float currDis = 0;

	void Start()
	{
		deathPosition = GameObject.FindGameObjectWithTag("Death").transform.position;
		manState = true;
	}
	
	// Update is called once per frame
	void Update () {
		
		if(!Camera.main.GetComponent<GameProperty>()._PauseGame)
		{
			transform.position = new Vector3(transform.position.x - Time.deltaTime * speed, transform.position.y, transform.position.z);
		}

		if(Vector2.Distance(transform.position, deathPosition) < distance && manLight == null)
		{
			manLight = Instantiate(masLight[(int)(manType)], Vector3.zero, Quaternion.identity) as GameObject;
			manLight.transform.parent = transform;
			manLight.transform.localScale = new Vector3(1, 1, 1);
			manLight.transform.localPosition = Vector3.zero;
			manLight.transform.localEulerAngles = new Vector3(-90, 0, 0);
		}

		if(transform.position.x < -25.0f)
		{
		    Destroy(gameObject);
		}
 
		if(Camera.main.GetComponent<GameProperty>()._StartGame && !Camera.main.GetComponent<GameProperty>()._PlayAnim)
		{
			if(manState)
			{
				if(transform.position.x - deathPosition.x < -2)
				{/* 
					switch(Camera.main.GetComponent<setLevelScript>().currentLevel)
					{
						case 1: if(manType == MAN_TYPE.TYPE_BAD || manType == MAN_TYPE.TYPE_GOOD) 
								Camera.main.GetComponent<GameProperty>()._FinishGame = true;
								break;
						case 2: if(manType == MAN_TYPE.TYPE_GOOD) 
								Camera.main.GetComponent<GameProperty>()._FinishGame = true;
								break;
						case 3: if(manType == MAN_TYPE.TYPE_BAD) 
								Camera.main.GetComponent<GameProperty>()._FinishGame = true;
								break;
						case 4: Camera.main.GetComponent<GameProperty>()._FinishGame = true;
								break;
						case 5: if(manType == MAN_TYPE.TYPE_BAD || manType == MAN_TYPE.TYPE_GOOD) 
								Camera.main.GetComponent<GameProperty>()._FinishGame = true;
								break;
					}*/
				}
			}
		}		
	}
}
