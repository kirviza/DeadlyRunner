using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using GooglePlayGames;
using GooglePlayGames.BasicApi;
using UnityEngine.SocialPlatforms;

public class GameProperty : MonoBehaviour {

	public bool _StartGame;

	public bool _FinishGame;

	public bool _PauseGame;

	public bool _NeedCreateMan;

	public bool _NewLevel;

	public bool _PlayAnim;
	public bool _PlayMenuAnim;
	public bool _PlayLevelAnim;

	public int _BestScore;

	public int _CurScore;

	public GameObject LineFinishResult;
	public GameObject LineBestResult;
	public GameObject MainMenu;	

	public GameObject TextLevel;

	private const string leaderBoard = "CgkIkcTti8sNEAIQBg";


	void Start()
	{
		_StartGame = false;
		_PauseGame = false;
		_NeedCreateMan = false;
		_PlayAnim = false;
		_FinishGame = false;
		_NewLevel = true;

		PlayGamesPlatform.DebugLogEnabled = false;
		PlayGamesPlatform.Activate();
		Social.localUser.Authenticate((bool success) => {
			if(success)
			{
				Debug.Log("Good A");
			}else{
				Debug.Log("Bad A");

			}
		});
	}

	void Update()
	{
		if(_FinishGame)
		{
			_StartGame = false;
			_PauseGame = false;
			_NeedCreateMan = false;
			_PlayAnim = false;
			_FinishGame = false;
			_NewLevel = true;

			GetComponent<setLevelScript>().currentLevel = 1;
			GetComponent<setLevelScript>().level = 1;
			GetComponent<setLevelScript>().currentScore = 0;

			TextLevel.transform.localScale = new Vector3(0, 0, 0);

			_CurScore = GetComponent<ScoreScript>().scoreI;
			if(_CurScore > _BestScore)
				_BestScore = _CurScore;

			if(_BestScore > PlayerPrefs.GetInt("score"))
			{
				PlayerPrefs.SetInt("score", _BestScore);
				Social.ReportScore(_BestScore, leaderBoard, (bool success) =>
				{
					if (success) Debug.Log("GOOD");
					else Debug.Log("BAD");
				});
			}

			LineFinishResult.GetComponent<Text>().text = "текущий результат: " + _CurScore.ToString();
			LineBestResult.GetComponent<Text>().text = "лучший результат: " + _BestScore.ToString();
			MainMenu.GetComponent<Animation>().Play("FinishAnim");	
			
			GetComponent<ScoreScript>().scoreI = 0;
			GetComponent<ScoreScript>().scoreF = 0;		
		}
		
		if(_StartGame && !_PlayAnim && !_NewLevel)
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
