using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class contenedor : MonoBehaviour {
	playermenu pl;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(){
	
		playermenu.energia--;
		print (playermenu.energia);
	}

}
