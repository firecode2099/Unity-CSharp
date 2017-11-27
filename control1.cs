using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control1 : MonoBehaviour {


	healplayer h;


	// Update is called once per frame
	void Update () {


		if(healplayer.healt==0){

			Application.LoadLevel ("end");
		}

	}
}
