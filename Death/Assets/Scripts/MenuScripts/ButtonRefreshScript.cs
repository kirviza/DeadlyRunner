using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonRefreshScript : MonoBehaviour {

	public GameObject buttonPause;
	
	void OnMouseUp()
	{
		buttonPause.SetActive(true);
		gameObject.SetActive(false);
		Time.timeScale = 1;
		Camera.main.GetComponent<GameProperty>()._PauseGame = false;
	}
}
