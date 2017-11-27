using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour {

	public Animator ani;
	public GameObject go4,go5;
	//Estoy accediendo a energia de player
	//healplayer hp;
	//acceso al  contador de puntos

	void OnCollisionEnter2D(){
		ani.SetBool ("fd",true);
		go5.transform.Translate( new Vector3(-5,2,0));



		healplayer.Score+=10;

		Destroy (go4);


	
	}



}
