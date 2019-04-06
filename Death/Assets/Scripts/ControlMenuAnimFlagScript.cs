using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlMenuAnimFlagScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Camera.main.GetComponent<GameProperty>()._PlayMenuAnim = GetComponent<Animation>().isPlaying;
	}
}
