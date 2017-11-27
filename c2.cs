using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class c2 : MonoBehaviour {
	
	playermenu energiaup;

	public GameObject go;
	void OnTriggerEnter2D(){
		
		playermenu.Score++;
		Destroy (go);
	} 



}
