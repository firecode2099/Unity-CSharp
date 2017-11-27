/*
prueba de activacion de canvas  e imagenes
*/
/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class canvas3 : MonoBehaviour {
	playermenu energia;
	public Image im;
	 Canvas ca;
	void Awake(){
		



	}


	void Start () {
		ca = GetComponent<Canvas>();	
		//ca.enabled =!ca.enabled ;
		//im  =  GameObject.Find("canvas").GetComponent<Image>();
		//im.sprite = Resources.Load<Sprite> ("Sprites/heart");



	}

	void Update(){

		im.sprite = Resources.Load<Sprite> ("Sprites/heart");
		if(playermenu.energia==9){
			ca.enabled =true ;

		}


		if(Input.GetKey(KeyCode.F)){
			ca.enabled =true ;
		//	im.sprite = Resources.Load<Sprite> ("Sprites/heart");

					
		}

		if(Input.GetKey(KeyCode.G)){
			im.sprite = Resources.Load<Sprite> ("Sprites/heart");


		}


	}


}
*/