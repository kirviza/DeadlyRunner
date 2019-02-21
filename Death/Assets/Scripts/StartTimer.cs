using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartTimer : MonoBehaviour {

	public Transform allMen;
	public GameObject myTimer;
	public bool startAn = false;
	public bool stopAn = true;
	private bool stateAn = false;
	// Use this for initialization
	void Start () {
		startAn = true;
	}
	
	// Update is called once per frame
	void Update () {
		if(startAn)// && allMen.childCount == 0)
		{
			myTimer.GetComponent<Animation>().Play();
			startAn = !startAn;
			stopAn = false;
		}

		stateAn = myTimer.GetComponent<Animation>().isPlaying;

		if(!stateAn && !stopAn)
		{
			stopAn = true;
		}
		
	}
}
