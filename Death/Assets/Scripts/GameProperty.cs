using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameProperty : MonoBehaviour {

	public bool _StartGame;

	public bool _NeedCreateMan;

	public bool _PlayAnim;

	public int _BestScore;

	public int _CurScore;

	void Start()
	{
		_StartGame = false;
		_NeedCreateMan = false;
		_PlayAnim = false;
	}

	void Update()
	{
		if(_StartGame && !_PlayAnim)
		{
			_NeedCreateMan = true;
		}else
		{
			_NeedCreateMan = false;
		}
	}

}
