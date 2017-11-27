using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sacar : MonoBehaviour {
	healplayer h;

	public GameObject go6;






	void OnCollisionEnter2D( ){


		healplayer.healt--;
		print (healplayer.healt);
		Destroy (go6);
	}



}
