using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setLevelScript : MonoBehaviour {

	public int modValue = 10;
	public GameObject ScoreLine;
	public GameObject LevelAnimation;


	public int currentLevel = 1;
	private const int countLevel = 5;
	private int currentScore = 0;

	void Start () {
		currentLevel = 1;
	}
	
	void Update () {
		if(GetComponent<GameProperty>()._StartGame)
		{
			int score = GetComponent<ScoreScript>().scoreI;
			if(score%modValue == 0 && (score - currentScore) > 0)
			{
				currentScore = score;
				if(currentLevel != 1)
				{
					currentLevel = 1;
				}else
				{
					currentLevel =  Random.Range(2, countLevel);
				}
				LevelAnimation.GetComponent<StartStopLevelAnimation>().StartStopAn = true;
			}
		}
	}
}

