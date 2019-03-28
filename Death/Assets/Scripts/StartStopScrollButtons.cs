using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartStopScrollButtons : MonoBehaviour {

	// Use this for initialization
	public bool UpDownAn = false;
	public bool StartStopAn = false;

	

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(StartStopAn)
		{			
			if(UpDownAn)
			{
				gameObject.GetComponent<Animation>().Play("EndGroupButtonsUp");
			}else
			{
				gameObject.GetComponent<Animation>().Play("EndGroupButtonsDown");
			}
			StartStopAn = !StartStopAn;
			UpDownAn = !UpDownAn;
		}		
	}
}
