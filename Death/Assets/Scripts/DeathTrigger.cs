using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathTrigger : MonoBehaviour {
	public GameObject man;

	void OnTriggerEnter2D(Collider2D other)
	{
		man = other.gameObject;
	}
	void OnTriggerExit2D(Collider2D other)
	{
		man = null;
	}
}
