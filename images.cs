/*Bien script 
  para colocar imagenes en lugar de la energia 
  a media que deciende la energia 
  bajan los corazones
    
   */ 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class images : MonoBehaviour {


	//playermenu energia;

	public Image im;
	/*
	public Image im1;
	public Image im2;
	public Image im3;
	public Image im4;
	public Image im5;
*/
	// Use this for initialization
	void Start () {

		im  =  GameObject.Find("canvas2").GetComponent<Image>();
		/*
		im1 = GameObject.Find("canvas").GetComponent<Image>();
		im2 = GameObject.Find("canvas2").GetComponent<Image>();
		im3 = GameObject.Find("canvas2").GetComponent<Image>();
		im4 = GameObject.Find("canvas2").GetComponent<Image>();
		im5 = GameObject.Find("canvas2").GetComponent<Image>();
*/

	}
	
	// Update is called once per frame
	void Update () {

		e ();
	}
	void e(){
		if(Enegiajefe1.energb1==9f){
			//Destroy (im);

			im.sprite = Resources.Load<Sprite> ("Sprites/9");
		}
		if(Enegiajefe1.energb1==8f){
			//Destroy (im);

			im.sprite = Resources.Load<Sprite> ("Sprites/8");
		}
		if(Enegiajefe1.energb1==7f){
			//Destroy (im);

			im.sprite = Resources.Load<Sprite> ("Sprites/7");
		}
		if(Enegiajefe1.energb1==6f){
			//Destroy (im);

			im.sprite = Resources.Load<Sprite> ("Sprites/6");
		}
		if(Enegiajefe1.energb1==5f){
			//Destroy (im);

			im.sprite = Resources.Load<Sprite> ("Sprites/5");
		}
		if(Enegiajefe1.energb1==4f){
			//Destroy (im);

			im.sprite = Resources.Load<Sprite> ("Sprites/4");
		}
		if(Enegiajefe1.energb1==3f){
			//Destroy (im);

			im.sprite = Resources.Load<Sprite> ("Sprites/3");
		}
		if(Enegiajefe1.energb1==2f){
			//Destroy (im);

			im.sprite = Resources.Load<Sprite> ("Sprites/2");
		}
		if(Enegiajefe1.energb1==1f){
			//Destroy (im);

			im.sprite = Resources.Load<Sprite> ("Sprites/1");
		}


		/*
		//Busca sprite en carpeta de Resource/sprite
		im.sprite = Resources.Load<Sprite> ("Sprites/heart");
		im.sprite = Resources.Load<Sprite> ("Sprites/heart");
		im1.sprite = Resources.Load<Sprite> ("Sprites/heart");
		im2.sprite = Resources.Load<Sprite> ("Sprites/heart");
		im3.sprite = Resources.Load<Sprite> ("Sprites/heart");
		im4.sprite = Resources.Load<Sprite> ("Sprites/heart");
		im5.sprite = Resources.Load<Sprite> ("Sprites/heart");

		if(playermenu.energia==9){
			Destroy (im);

		}

		if(playermenu.energia==8){
			 Destroy (im1);
			}
		if(playermenu.energia==7){
		   Destroy (im2);

		}
		if(playermenu.energia==6){
			Destroy (im3);
		}
		if(playermenu.energia==5){
			Destroy (im4);
		}

	}

	*/

}
}
