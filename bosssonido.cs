using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bosssonido : MonoBehaviour {

	public float conta=0.0f;
	public AudioClip audio=null;//objeto donde colocar el audio
	protected Transform Position;//posision sino no suena
	public float volumen =1.0f;//volumen


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		conta++;
		if(conta==10){

			Position = transform;
			if (audio) {//si ahy audio llamamo al sonido
				AudioSource.PlayClipAtPoint (audio, Position.position, volumen);//pasamos tres referencias 


				//Audio,posision y volumen



		}

	}
}


}
