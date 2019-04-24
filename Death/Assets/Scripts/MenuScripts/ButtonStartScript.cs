using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonStartScript : MonoBehaviour {
	
	private bool firstStart = true;

	void Start()
	{
		firstStart = true;
	}
	
	void OnMouseUp()
	{
		Camera.main.GetComponent<GameProperty>()._StartGame = true;

		if(firstStart)
		{
			gameObject.GetComponentInParent<Animation>().Play("FirstStartAnim");
		}
		else
		{
			gameObject.GetComponentInParent<Animation>().Play("FirstStartAnim");
		}

	}
}
