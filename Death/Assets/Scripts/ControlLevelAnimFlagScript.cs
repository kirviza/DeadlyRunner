using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlLevelAnimFlagScript : MonoBehaviour {
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Camera.main.GetComponent<GameProperty>()._PlayLevelAnim = GetComponent<Animation>().isPlaying;

		if(Camera.main.GetComponent<GameProperty>()._StartGame)
		{
			GetComponentInChildren<Text>().enabled = true;
		}else
		{
			GetComponentInChildren<Text>().enabled = false;
		}
	}
}
