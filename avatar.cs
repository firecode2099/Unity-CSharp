using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class avatar : MonoBehaviour {

	public Animator ani;
	public GameObject go,go2;
	public float tiempo=0.0f;
	public void OnCollisionEnter2D(){

		ani.SetBool ("avatar",true);

		Destroy (go);
		go2.transform.Translate (10,0,0);

	}
	// Update is called once per frame
	void Update () {
		
	}



	void b(){
	
		Application.LoadLevel ("1-1");
	}
}
