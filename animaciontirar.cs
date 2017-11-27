using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animaciontirar : MonoBehaviour {
	public Animator a;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {




		if (Input.GetKeyUp(KeyCode.D)) {

			a.SetBool ("t", true);
			print ("has presionado f");

		} else {
		
			a.SetBool ("t", false);

		
		}



	}
}
