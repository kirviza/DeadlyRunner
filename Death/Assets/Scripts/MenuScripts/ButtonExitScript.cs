using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonExitScript : MonoBehaviour {

	void OnMouseUp()
	{
		if(Camera.main.GetComponent<GameProperty>()._PauseGame)
		{
			gameObject.GetComponentInParent<Animation>().Play("CallExitMenuPauseAnim");
		}else
		{
			gameObject.GetComponentInParent<Animation>().Play("CallExitMenuAnim");
		}
	}
}
