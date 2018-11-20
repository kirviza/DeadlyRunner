using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Strike : MonoBehaviour {

	public GameObject death;
	public GameObject goodSoul;
	public GameObject badSoul;
	public GameObject lostSoul;

    void OnMouseDown (){
		if(death.GetComponent<DeathTrigger>().man)
		{
			GameObject man = death.GetComponent<DeathTrigger>().man;
			if(man.GetComponent<ManRun>().needDead == 1)
			{
				if(man.tag == "goodMan")
				{
					Instantiate(goodSoul, man.transform.position, Quaternion.identity);
				}else
				{
					Instantiate(badSoul, man.transform.position, Quaternion.identity);
				}
				Destroy(man);
			}else
			{
				death.GetComponent<lostSoulCreate>().needCreate = true;
				Destroy(man);
			}		
		}
	}
	
}
