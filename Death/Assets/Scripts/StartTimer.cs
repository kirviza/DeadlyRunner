using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartTimer : MonoBehaviour {

	public bool startAn = false;
	public bool stopAn = false;
	private bool stateAn = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(startAn)
		{
			gameObject.GetComponent<Animation>().Play();
			startAn = !startAn;
			stopAn = true;
		}

		stateAn = gameObject.GetComponent<Animation>().isPlaying;

		if(!stateAn && stopAn)
		{
			stopAn = false;
		}
		
	}
}
