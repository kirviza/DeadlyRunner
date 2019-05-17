using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonSound : MonoBehaviour {

	public GameObject tabBox;
	private bool soundState = true;
	// Use this for initialization
	void Start () {
		
	}
	
	void OnMouseUp()
	{
		if(soundState)
		{
			GetComponent<Text>().text = "Off sound";
			soundState = false;
			tabBox.GetComponent<AudioSource>().enabled = false;
		}else
		{
			GetComponent<Text>().text = "On sound";
			soundState = true;
			tabBox.GetComponent<AudioSource>().enabled = true;
		}
	}
}
