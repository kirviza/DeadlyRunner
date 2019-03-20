using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setLevelScript : MonoBehaviour {

	public bool startLevel = false;

	public int currentScore = 0;
	public int countLevel = 5;
	public int currentLevel = 1;
	public int randLevel = 1;

	public int modValue = 10;

	// Use this for initialization
	void Start () {
		startLevel = false;
		currentLevel = 1;
		randLevel = 1;
	}
	
	// Update is called once per frame
	void Update () {
		
		currentScore = GetComponent<ScoreScript>().scoreI;
		if(currentScore%modValue == 0 && startLevel)
		{
			GetComponent<StartTimer>().startAn = true;
			while(randLevel == currentLevel)
			{
				randLevel = Random.Range(1, countLevel);
			}
			currentLevel = randLevel;
			startLevel = false;
		}
		if(currentScore%modValue != 0)
		{
			startLevel = true;
		}

		
	}
}
