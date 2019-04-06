using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartStopLevelAnimation : MonoBehaviour {

	private bool visibleState = false;
	public bool StartStopAn = false;

	private int level = 1;

	void Start () {
		level = 1;
		StartStopAn = true;
		visibleState = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(Camera.main.GetComponent<GameProperty>()._StartGame && !GetComponent<Animation>().isPlaying)
		{
			if(StartStopAn)
			{			
				if(visibleState)
				{
					string LevelName = "Level_"+ level +"_Stop";
					GetComponent<Animation>().Play(LevelName);
					StartStopAn = true;
					visibleState = false;
				}else
				{
					level = Camera.main.GetComponent<setLevelScript>().currentLevel;
					string LevelName = "Level_"+ level.ToString() +"_Start";
					GetComponent<Animation>().Play(LevelName);
					StartStopAn = false;
					visibleState = true;
				}
			}
		}
		if(Camera.main.GetComponent<GameProperty>()._StartGame == false)
		{
			//GetComponent<Animation>().
		}

	}
}
