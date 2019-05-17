using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonNoExitScript : MonoBehaviour {

	void OnMouseUp()
	{
		if(Camera.main.GetComponent<GameProperty>()._PauseGame)
		{
			gameObject.GetComponentInParent<Animation>().Play("NoExitPauseAnim");
		}else
		{
			gameObject.GetComponentInParent<Animation>().Play("NoExitAnim");
		}
	}
}
