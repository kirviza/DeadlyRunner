using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GooglePlayGames;
using UnityEngine.SocialPlatforms;

public class ButtonRecordScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	void OnMouseUp()
	{
		Social.ShowLeaderboardUI();
	}
}
