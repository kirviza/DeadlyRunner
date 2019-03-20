using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartStopLevelAnimation : MonoBehaviour {

	private bool visibleState = false;
	public bool StartStopAn = false;

	private int lastLevel = 1;

	void Start () {
		lastLevel = 1;
		StartStopAn = true;
		visibleState = false;
	}
	
	// Update is called once per frame
	void Update () {
		
		if(StartStopAn)
		{			
			if(visibleState)
			{
				string LevelName = "Level_"+ lastLevel +"_Stop";
				GetComponent<Animation>().Play(LevelName);
				Camera.main.GetComponent<CreateMans>().needCreate = false;
			}else
			{
				lastLevel = Camera.main.GetComponent<setLevelScript>().currentLevel;
				string LevelName = "Level_"+ lastLevel.ToString() +"_Start";
				GetComponent<Animation>().Play(LevelName);
				Camera.main.GetComponent<CreateMans>().needCreate = false;
			}
			StartStopAn = !StartStopAn;
			visibleState = !visibleState;
		}

		if(!GetComponent<Animation>().isPlaying && !visibleState)
		{
			StartStopAn = true;
		}

		if(!GetComponent<Animation>().isPlaying && visibleState)	
		{
			Camera.main.GetComponent<CreateMans>().needCreate = true;
		}	
	}
}
