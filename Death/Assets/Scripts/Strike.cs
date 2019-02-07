using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Strike : MonoBehaviour {

	public GameObject death;
	public GameObject goodSoul;
	public GameObject badSoul;
	public GameObject lostSoul;

    void OnMouseDown (){
		// кусок кода от ромаша
		// по нажатию кнопки запускаем анимацию удара
		death.GetComponent<Animator>().SetTrigger("touch");
		// конец церь-кода ромаша
		if(death.GetComponent<DeathTrigger>().man)
		{
			GameObject man = death.GetComponent<DeathTrigger>().man;
			if(man.GetComponent<ManRun>().needDead == 1)
			{
				if(man.tag == "goodMan")
				{
					Instantiate(goodSoul, man.transform.position, Quaternion.identity);
					Camera.main.GetComponent<health>().healthVolume -= 20.0f;
					if(Camera.main.GetComponent<health>().healthVolume < 0)
						Camera.main.GetComponent<health>().healthVolume = 0;
				}else
				{
					Instantiate(badSoul, man.transform.position, Quaternion.identity);
					Camera.main.GetComponent<health>().healthVolume -= 20.0f;
					if(Camera.main.GetComponent<health>().healthVolume < 0)
						Camera.main.GetComponent<health>().healthVolume = 0;
				}

				man.GetComponent<ManRun>().head.GetComponent<ForceScript>().enabled = true;

				//Destroy(man);
			}else
			{
				death.GetComponent<lostSoulCreate>().needCreate = true;

				man.GetComponent<ManRun>().head.GetComponent<ForceScript>().enabled = true;
				
				//Destroy(man);
			}		
		}
	}
	
}
