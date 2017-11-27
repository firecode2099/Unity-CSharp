using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class start : MonoBehaviour {


	 public float   contador=0.0f;
	// Use this for initialization
	void Start () {
		
	
	}
	
	// Update is called once per frame
	void Update () {
		if(contador>1999.0f){

			contador = 0.0f;

		}

		contador++;
		print (contador);
		if(contador==2000.0f){

			Application.LoadLevel("pre");

		}






		if(Input.GetKey(KeyCode.Return)){
		
			Application.LoadLevel ("a");
			print ("has presiona do enter");
		}

	}
}
