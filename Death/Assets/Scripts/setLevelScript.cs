using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class setLevelScript : MonoBehaviour {

	public int modValue = 10;
	public GameObject ScoreLine;
	public GameObject LevelAnimation;

	public GameObject AllMen;


	public int currentLevel = 1;
	public int level = 1;
	public int currentScore = 0;
	private const int countLevel = 5;
	

	void Start () {
		currentLevel = 1;
		level = 1;
	}
	
	void Update () {
		if(GetComponent<GameProperty>()._StartGame)
		{
			int score = GetComponent<ScoreScript>().scoreI;
			if(score%modValue == 0 && (score - currentScore) > 0)
			{
				currentScore = score;
				if(level != 1)
				{
					level = 1;
				}else
				{
					level =  Random.Range(2, countLevel);
				}
				GetComponent<GameProperty>()._NewLevel = true;
			}

			if(GetComponent<GameProperty>()._NewLevel && !GetComponent<GameProperty>()._PlayAnim  &&  AllMen.transform.childCount == 0) 
			{
				currentLevel = level;
				LevelAnimation.GetComponentInChildren<Text>().text = "Level " + currentLevel.ToString();
				LevelAnimation.GetComponent<Animation>().Play();
				GetComponent<GameProperty>()._NewLevel = false;
			}
		}
	}
}

