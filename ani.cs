/*
script que encuantra animaciones

*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ani : MonoBehaviour {
	healplayer h;
	float speed=5.0f;
	public    static Animator anima;

	//sonido
	public AudioClip audio=null;//objeto donde colocar el audio
	protected Transform Position;//posision sino no suena
	public int volumen =1;//volumen


	void dessalto(){
		anima.SetBool ("jump", false);

	}


	void Start(){
		//letras = GetComponent<Canvas> ();
		speed = Time.deltaTime;


	}



	// Update is called once per frame
	void Update () {

	

		if (Input.GetKey (KeyCode.A) && Input.GetKey (KeyCode.Space) && !Input.GetKey (KeyCode.D)) {

			anima.SetBool ("jumpi", true);


		} else {
			anima.SetBool ("jumpi", false);

		}


		if (Input.GetKeyDown(KeyCode.Space)&&Input.GetKeyDown(KeyCode.D)) {

			anima.SetBool ("jump", true);

		}else {
			anima.SetBool ("jump", false);

		}


		if (Input.GetKeyDown(KeyCode.Space)) {

			anima.SetBool ("jump", true);


		} else {

			anima.SetBool ("jump", false);



		if (healplayer.healt==0.0f) {
				  
			anima.SetBool ("dead", true);

		} 
					
	    
		//sonido

			if(Input.GetKey(KeyCode.Space)){
			Position = transform;//coloccamos posision

			AudioSource.PlayClipAtPoint (audio, Position.position, volumen);//pasamos tres referencias 



		}	



		if (Input.GetKey(KeyCode.D)&&!Input.GetKey(KeyCode.A)) {

			anima.SetBool ("t", true);
			
		} else {
		
			anima.SetBool ("t", false);

		}



		if (Input.GetKey(KeyCode.A)&&!Input.GetKey(KeyCode.D)) {

			anima.SetBool ("y", true);

		} else {

			anima.SetBool ("y", false);

               }


		if (Input.GetKey(KeyCode.S)) {

			anima.SetBool ("abajo", true);

		} else {

			anima.SetBool ("abajo", false);

		}


		if (Input.GetKey(KeyCode.Space)) {

			anima.SetBool ("jump", true);


		} else {

			anima.SetBool ("jump", false);

		}
		if (Input.GetKey(KeyCode.F)) {

			anima.SetBool ("dis", true);

		} else {
			anima.SetBool ("dis", false);

		}

	}

}





}
