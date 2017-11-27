using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class save : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	void OnGUI(){

		if(Input.GetKey(KeyCode.X)){

			//save
			GUI.Box(new Rect(200,200,100,20),"Save");
		}


	
	}
}
