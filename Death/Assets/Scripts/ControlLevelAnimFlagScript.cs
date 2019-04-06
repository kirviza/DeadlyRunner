using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlLevelAnimFlagScript : MonoBehaviour {
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Camera.main.GetComponent<GameProperty>()._PlayLevelAnim = GetComponent<Animation>().isPlaying;
	}
}
