using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour {

	// Use this for initialization
	void OnMouseDown()
	{
		transform.localScale = new Vector3 (0.5f, 0.5f, 0.5f);
	}

	void OnMouseUp()
	{
		transform.localScale = new Vector3 (1f, 1f, 1f);
	}
}
