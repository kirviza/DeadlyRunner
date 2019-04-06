using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour {
	public int scoreI = 0;

	public float speedScore = 0.5f;
	public float scoreF = 0;

	public GameObject ScoreLine;
	

	// Use this for initialization
	void Start () {
		scoreF = 0;
		scoreI = 0;
		ScoreLine.GetComponent<Text>().text = "расстояние: 0";
	}
	
	// Update is called once per frame
	void Update () {

		if(GetComponent<GameProperty>()._StartGame  && !GetComponent<GameProperty>()._PlayMenuAnim)
		{
			scoreF += Time.deltaTime;
			scoreI = (int)(scoreF/speedScore);
			ScoreLine.GetComponent<Text>().text = "расстояние: " + scoreI.ToString();
			GetComponent<GameProperty>()._CurScore = scoreI;
		}
	}
}
