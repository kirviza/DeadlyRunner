using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RefreshButton : MonoBehaviour {
	
	public GameObject EndButtonGroup;	
	
	void OnMouseUp()
	{
		EndButtonGroup.GetComponent<StartStopScrollButtons>().StartStopAn = true;
		Camera.main.GetComponent<CreateMans>().enabled = true;
		Camera.main.GetComponent<ScoreScript>().scoreText.enabled = true;
		Camera.main.GetComponent<ScoreScript>().enabled = true;	
		Camera.main.GetComponent<health>().stateStart = true;
		Camera.main.GetComponent<health>().healthSlider.gameObject.SetActive(true);
		Camera.main.GetComponent<health>().healthVolume = 0;
		Camera.main.GetComponent<StartTimer>().startAn = true;
	}
}
