/*Script para imprimir en un gui la energia del player

tomamos la variable energia y la comvertimos string

*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playermenu : MonoBehaviour {

	//variable enrgia de player con stactick

	//hay acceso desde otros scripts
	public static  int energia=11;
	public static  float Score=0.0f;
	public animaciones a;

	void	Start (){
		
	
	}


	//controlde collision para game over
	public void OnCollisionEnter2D(){
	     
		//energia-=1;
	
	} 



	void Update(){
	
	
	}



	//Funcion GUi
	void OnGUI(){
	
		GUI.Box (new Rect(200,0,100,20),"Score:"+Score.ToString());
	
	}

}
