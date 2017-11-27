using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anienmego : MonoBehaviour {


	public Animator an;

	int conti=0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		conti++;


		if(conti>5){
			
			conti=0;

		}


		if(conti>1){
			an.SetBool ("enemi",true);


		}

		if(conti<1){
			an.SetBool ("enemi",false);


		}

	}
}
