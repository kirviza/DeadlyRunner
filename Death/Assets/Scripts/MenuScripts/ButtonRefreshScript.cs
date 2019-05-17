using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonRefreshScript : MonoBehaviour {

	public GameObject buttonPause;
	
	void OnMouseUp()
	{
		gameObject.GetComponentInParent<Animation>().Play("CancelPauseAnim");
		Time.timeScale = 1;
		Camera.main.GetComponent<GameProperty>()._PauseGame = false;
	}
}
