/*
avatar para controlar la muerte del personaje
si tocamos morimos y quita vida
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class avatar2 : MonoBehaviour {


	public Animator ani;
	public GameObject go,go2;

	public void OnCollisionEnter2D(){
		ani.SetBool ("man",true);

		//Application.LoadLevel("1-1");
		Destroy(go);
		healplayer.healt -= 1;
	}



	void dead(){
	
		if (healplayer.healt == 0.0f) {

			Destroy (go2);
			Application.LoadLevel ("end");


		} else {
			Application.LoadLevel ("1");
		}


}

}