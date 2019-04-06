using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameProperty : MonoBehaviour {

	public bool _StartGame;

	public bool _FinishGame;

	public bool _NeedCreateMan;

	public bool _PlayAnim;
	public bool _PlayMenuAnim;
	public bool _PlayLevelAnim;

	public int _BestScore;

	public int _CurScore;

	void Start()
	{
		_StartGame = false;
		_NeedCreateMan = false;
		_PlayAnim = false;
		_FinishGame = false;
	}

	void Update()
	{
		if(_FinishGame)
		{
			_StartGame = false;
			
			_FinishGame = false;
			GetComponent<setLevelScript>().currentLevel = 1;
			_CurScore = GetComponent<ScoreScript>().scoreI;
			if(_CurScore > _BestScore)
				_BestScore = _CurScore;

			GameObject.Find("LineFinishResult").GetComponent<Text>().text = "текущий результат: " + _CurScore.ToString();
			GameObject.Find("LineBestResult").GetComponent<Text>().text = "лучший результат: " + _BestScore.ToString();
			GameObject.Find("MainMenu").GetComponent<Animation>().Play("FinishAnim");	
			GetComponent<ScoreScript>().scoreI = 0;
			GetComponent<ScoreScript>().scoreF = 0;
			
		}
		
		if(_StartGame && !_PlayAnim)
		{
			_NeedCreateMan = true;
		}else
		{
			_NeedCreateMan = false;
		}

		if(_PlayMenuAnim || _PlayLevelAnim)
		{
			_PlayAnim = true;
		}else
		{	
			_PlayAnim = false;
		}


		
	}

}
