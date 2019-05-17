using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPauseScript : MonoBehaviour {

	public GameObject buttonRefresh;

	void OnApplicationFocus (bool hasFocus)
    {
		if(!hasFocus)
        {
			Camera.main.GetComponent<GameProperty>()._PauseGame = true;
            gameObject.GetComponentInParent<Animation>().Play("PauseAnim");
			//Time.timeScale = 0;
        }
    } 
    void OnMouseUp()
	{
		Camera.main.GetComponent<GameProperty>()._PauseGame = true;
		gameObject.GetComponentInParent<Animation>().Play("PauseAnim");
		//Time.timeScale = 0;
	}
}
