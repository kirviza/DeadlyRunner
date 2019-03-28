using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Strike : MonoBehaviour {

	public GameObject death;
/* 	public GameObject goodSoul;
	public GameObject badSoul;
	public GameObject lostSoul;
	public Transform parent;*/

  void OnMouseDown (){

		if(Camera.main.GetComponent<GameProperty>()._StartGame && !Camera.main.GetComponent<GameProperty>()._PlayAnim)
		{
			//Запуск анимации удара
			death.GetComponent<Animator>().SetTrigger("touch");
		}
		

		/* if(death.GetComponent<DeathTrigger>().man)
		{
			GameObject man = death.GetComponent<DeathTrigger>().man;
			if(man.GetComponent<ManRun>().needDead == 1)
			{
				if(man.tag == "goodMan")
				{
					Instantiate(goodSoul, man.transform.position, Quaternion.identity, parent);				
				}else
				{
					Instantiate(badSoul, man.transform.position, Quaternion.identity, parent);
				}

				man.GetComponent<ManRun>().head.GetComponent<ForceScript>().enabled = true;

			}else
			{
				;man.GetComponent<ManRun>().head.GetComponent<ForceScript>().enabled = true;
			}		
		}*/
	}
	
}
