using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plataforma : MonoBehaviour {
	private  float contador=0.0f;
	// Use this for initialization
	void Start () {
		contador = Time.deltaTime;
	}
	
	// Update is called once per frame
	void Update () {
		contador++;
		print (contador);
	
		if(contador==1){

			transform.Translate (new Vector3(0,5,0)*Time.deltaTime);

		}

	


	}
}
