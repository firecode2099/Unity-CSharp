using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class contacto : MonoBehaviour {
	
	healplayer h;
	public GameObject go6;
	// Use this for initialization

	void OnCollisionEnter2D(){
		
		go6.transform.Translate( new Vector3(-5,2,0));

		//on trigger restar energia de player
		//healplayer.healt--;


		Destroy (go6);
		healplayer.healt--;
	}



}
