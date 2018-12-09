using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lostSoulCreate : MonoBehaviour {
	public bool needCreate = false;
	public int maxSoul = 3;
	public int countSoul = 0;
	public GameObject[] lostSoulMas;
	public GameObject lostSoul;

	public GameObject endButtonGroup;

	public Text YourScore;
	public Text BestScore;

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
				Camera.main.GetComponent<ScoreScript>().scoreText.enabled = false;
				Camera.main.GetComponent<health>().healthSlider.gameObject.SetActive(false);
				YourScore.text = " Your Score: " + Camera.main.GetComponent<ScoreScript>().scoreI.ToString();
				Camera.main.GetComponent<ScoreScript>().scoreText.text = "Score: 0";
				Camera.main.GetComponent<ScoreScript>().scoreF = 0;


				endButtonGroup.GetComponent<StartStopScrollButtons>().StartStopAn = true;

				for(int i = 0; i < countSoul; i++)
				{
					Destroy(lostSoulMas[i]);
				}
				countSoul = 0;
			}

		}
	}
}
