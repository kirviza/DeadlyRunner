using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonNoExitScript : MonoBehaviour {

	void OnMouseUp()
	{
		gameObject.GetComponentInParent<Animation>().Play("NoExitAnim");
	}
}
