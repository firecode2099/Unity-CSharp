using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cont : MonoBehaviour {


	private float con = 0.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		con++;
		print (con);
		if(con==100.0f){

			Application.LoadLevel("1");
		}
	}
}
