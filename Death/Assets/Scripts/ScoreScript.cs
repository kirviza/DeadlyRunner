using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour {
	public bool stateStart = false;
	public Text scoreText;

	public float speedScore = 0.5f;
	private float scoreF = 0;
	private int scoreI = 0;

	// Use this for initialization
	void Start () {
		scoreF = 0;
		scoreI = 0;
		scoreText.text = "Score: 0";
	}
	
	// Update is called once per frame
	void Update () {
		if(stateStart)
		{
			scoreF += Time.deltaTime;
			scoreI = (int)(scoreF/speedScore);
			scoreText.text = "Score: " + scoreI.ToString();
		}
	}
}
