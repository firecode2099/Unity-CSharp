using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu3 : MonoBehaviour {

	public float con=0.0f;


	
	// Update is called once per frame
	void Update () {
		con++;
		print (con);
		if(con>=700f){
			Application.LoadLevel ("mapa");

		}
		if(Input.GetKey(KeyCode.Return)){
            Application.LoadLevel("mapa");

		}

	
	}
}
