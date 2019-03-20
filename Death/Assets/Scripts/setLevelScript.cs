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

	public GameObject LevelAnimation;

	// Use this for initialization
	void Start () {
		countLevel = 5;
		startLevel = true;
		currentLevel = 1;
		randLevel = 1;
	}
	
	// Update is called once per frame
	void Update () {
		
		currentScore = GetComponent<ScoreScript>().scoreI;
		if(currentScore%modValue == 0 && startLevel)
		{
			if(currentLevel != 1)
			{
				currentLevel = 1;
			}else
			{
				randLevel = Random.Range(2, countLevel);
				currentLevel = randLevel;

				if(currentScore == 0)
					currentLevel = 1;
			}

			Camera.main.GetComponent<CreateMans>().whoNeedKill = currentLevel;

			startLevel = false;

			LevelAnimation.GetComponent<StartStopLevelAnimation>().StartStopAn = true;
		}
		if(currentScore%modValue != 0)
		{
			startLevel = true;
		}	
	}
}
