using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boton : MonoBehaviour {

	 public GameObject go,go2;
	public float speed=0.0f;

	// Use this for initialization
	void Start () {
		speed = Time.deltaTime;
		//go2.GetComponent<BoxCollider2D>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(){

		go.transform.Rotate(new Vector3(0,0,2700)*speed);
        go2.GetComponent<BoxCollider2D> ().enabled = false;
		//Destroy (go2);
	}



}
