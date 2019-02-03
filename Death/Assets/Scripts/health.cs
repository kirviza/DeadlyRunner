﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class health : MonoBehaviour {

	public bool stateStart = false;
	public float speed = 1.0f;
	public float healthVolume = 0;

	public Slider healthSlider;
	public GameObject death;
	public GameObject endButtonGroup;
	public Text YourScore;
	public Text BestScore;
	

	// Use this for initialization
	void Start () {
		healthVolume = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if(healthVolume >= 100.0f)
		{
			stateStart = false;
			healthVolume = 0.0f;

			healthSlider.gameObject.SetActive(false);

			Camera.main.GetComponent<CreateMans>().enabled = false;
			Camera.main.GetComponent<ScoreScript>().enabled = false;
			Camera.main.GetComponent<ScoreScript>().scoreText.enabled = false;
			Camera.main.GetComponent<ScoreScript>().scoreText.text = "Score: 0";
			Camera.main.GetComponent<ScoreScript>().scoreF = 0;

			YourScore.text = " Your Score: " + Camera.main.GetComponent<ScoreScript>().scoreI.ToString();

			endButtonGroup.GetComponent<StartStopScrollButtons>().StartStopAn = true;

			for(int i = 0; i < death.GetComponent<lostSoulCreate>().countSoul; i++)
			{
				Destroy(death.GetComponent<lostSoulCreate>().lostSoulMas[i]);
			}
			death.GetComponent<lostSoulCreate>().countSoul = 0;
		}
		if(stateStart)
		{
			healthVolume += Time.deltaTime * speed;
			healthSlider.GetComponent<Slider>().value = 100.0f - healthVolume;
		}
		
	}
}