/*
Control de animaciones animator
con variables float
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class animaciones : MonoBehaviour {

    float speed=5.0f; 
	float t=0f;
	public  Animator anim;
   // public GameObject objetoadestruir;
	void Start(){

		t = Time.fixedDeltaTime;



	}


	void dessalto(){
		anim.SetBool ("piso", true);

	}



	void FixedUpdate(){
	//probamos en FixedUpdate
		t++;
        //disparo
		if (Input.GetKey(KeyCode.F)) {
			anim.SetFloat ("dis",1);

		} else {
			anim.SetFloat ("dis",0);

		}



		//pesoaje dormir
		if (healplayer.healt == 3f && t <= 500f) {
			anim.SetBool ("dor", true);

		} else {
			
			anim.SetBool ("dor", false);

		}
		if (healplayer.Score >0f) {
			anim.SetBool ("dor", false);
			

		}





		//juego parado
		anim.SetBool ("juego",true);

		//anim.SetFloat ("subir2", 0);

		if (!Input.GetKey (KeyCode.Space)) {

			anim.SetBool ("juego", true);
			anim.SetBool ("piso", true);

		} else {

			anim.SetBool ("piso", false);
			anim.SetBool ("juego", false);

		}


		//Desactivamos en animacion
		if (Input.GetKey (KeyCode.D) && Input.GetKey (KeyCode.Space)) {
			anim.SetBool ("juego", false);



		} 

		if (Input.GetKey (KeyCode.A)) {

			anim.SetBool ("juego",false);
			anim.SetFloat ("speedi", 1);

		} else {
			anim.SetFloat ("speedi", 0);

		} 
        if (Input.GetKey (KeyCode.D)) {

			anim.SetBool ("juego",false);
			anim.SetFloat ("speed", 1);

		} else {
			anim.SetFloat ("speed", 0);

		} 

	}






}



