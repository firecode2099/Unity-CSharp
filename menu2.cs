using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class menu2 : MonoBehaviour {
	//public Transform fol;
	// Use this for initialization
	void Start () {
		
	}
	


	void Update(){

		//transform.LookAt(fol);

		if(Input.GetKey(KeyCode.Escape)){

			Application.Quit ();
			print ("escape");


		}


	}





}
