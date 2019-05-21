using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Strike : MonoBehaviour {

	public GameObject death;
 	public GameObject goodSoul;
	public GameObject badSoul;
	public Transform parent;

	public GameObject rip;

  void Update (){

	  	Vector2 CurMousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
	  	if(Input.GetMouseButtonDown(0))
		{
			RaycastHit2D rayHit = Physics2D.Raycast(CurMousePos, Vector2.zero);
            
            if(rayHit.transform !=null)
            {
                if(rayHit.transform != gameObject.transform)
				{
					return;
				}
            }

			if(Camera.main.GetComponent<GameProperty>()._StartGame && !Camera.main.GetComponent<GameProperty>()._PlayAnim && !Camera.main.GetComponent<GameProperty>()._PauseGame)
			{
				//Запуск анимации удара
				death.GetComponent<Animator>().SetTrigger("touch");

				if(gameObject.GetComponent<AudioSource>().enabled)
					gameObject.GetComponent<AudioSource>().Play();
			
				if(death.GetComponent<DeathTrigger>().man)
				{
					GameObject man = death.GetComponent<DeathTrigger>().man;

					man.GetComponent<ManRun>().manState = false;

					if(man.GetComponent<ManRun>().manType == MAN_TYPE.TYPE_BAD)
					{
						Instantiate(badSoul, man.transform.position, Quaternion.identity, parent);				
					}else if(man.GetComponent<ManRun>().manType == MAN_TYPE.TYPE_GOOD)
					{
						Instantiate(goodSoul, man.transform.position, Quaternion.identity, parent);
					}else
					{
						Instantiate(goodSoul, man.transform.position, Quaternion.identity, parent);
					}

					man.GetComponentInChildren<ForceScript>().enabled = true;
	
					switch(Camera.main.GetComponent<setLevelScript>().currentLevel)
					{
						case 1: if(man.GetComponent<ManRun>().manType == MAN_TYPE.TYPE_ZERO) 
								Camera.main.GetComponent<GameProperty>()._FinishGame = true;
								break;
						case 2: if(man.GetComponent<ManRun>().manType == MAN_TYPE.TYPE_ZERO || man.GetComponent<ManRun>().manType == MAN_TYPE.TYPE_BAD) 
								Camera.main.GetComponent<GameProperty>()._FinishGame = true;
								break;
						case 3: if(man.GetComponent<ManRun>().manType == MAN_TYPE.TYPE_ZERO || man.GetComponent<ManRun>().manType == MAN_TYPE.TYPE_GOOD) 
								Camera.main.GetComponent<GameProperty>()._FinishGame = true;
								break;
						case 4: break;
						case 5: if(man.GetComponent<ManRun>().manType == MAN_TYPE.TYPE_ZERO) 
								Camera.main.GetComponent<GameProperty>()._FinishGame = true;
								break;
					}

					Instantiate(rip, man.transform.position, Quaternion.identity);
					//Destroy(man);

				}
			}
		}
	}
	
}
