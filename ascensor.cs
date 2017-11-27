using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ascensor : MonoBehaviour {


	 public GameObject go;
	float gra=0.1f;
	// Use this for initialization
	void Start () {
		gra=Time.deltaTime;
	}

	void OnCollisionEnter2D(){
		
		go.GetComponent<Rigidbody2D> ().gravityScale = gra;


	}





}
