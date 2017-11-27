using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemigo1 : MonoBehaviour {

	public Animator ani;
	public void OnCollisionEnter2D(){

		ani.SetBool ("destruir",true);



	}


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
