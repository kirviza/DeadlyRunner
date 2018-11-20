using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lostSoulCreate : MonoBehaviour {

	public bool needCreate = false;
	public int maxSoul = 3;
	public int countSoul = 0;
	public GameObject[] lostSoulMas;
	public GameObject lostSoul;

	// Use this for initialization
	void Start () {
		lostSoulMas = new GameObject[maxSoul];
	}
	
	// Update is called once per frame
	void Update () {
		if(needCreate)
		{
			lostSoulMas[countSoul] = Instantiate(lostSoul, new Vector3(transform.position.x - 1.0f * (countSoul+1), transform.position.y, transform.position.z), Quaternion.identity);
			countSoul++;
			needCreate = !needCreate;
			if(countSoul == maxSoul)
			{
				Camera.main.GetComponent<CreateMans>().enabled = false;
				Camera.main.GetComponent<ScoreScript>().enabled = false;
			}

		}
	}
}
