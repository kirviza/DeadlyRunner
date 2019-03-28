using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour {
	public bool stateStart = false;
	public int scoreI = 0;

	public float speedScore = 0.5f;
	public float scoreF = 0;
	

	// Use this for initialization
	void Start () {
		scoreF = 0;
		scoreI = 0;
		GetComponent<Text>().text = "расстояние: 0";
	}
	
	// Update is called once per frame
	void Update () {

		if(Camera.main.GetComponent<GameProperty>()._StartGame)
		{
			scoreF += Time.deltaTime;
			scoreI = (int)(scoreF/speedScore);
			GetComponent<Text>().text = "расстояние: " + scoreI.ToString();
		}
	}
}
