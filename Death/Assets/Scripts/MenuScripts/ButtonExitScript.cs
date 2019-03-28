using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonExitScript : MonoBehaviour {

	void OnMouseUp()
	{
		gameObject.GetComponentInParent<Animation>().Play("CallExitMenuAnim");
	}
}
