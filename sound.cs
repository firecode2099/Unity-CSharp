using UnityEngine;
using UnityEngine.Audio;

using System.Collections;

public class sound : MonoBehaviour {


	//variables 

	public AudioClip audio=null;//objeto donde colocar el audio
	protected Transform Position;//posision sino no suena
	public float volumen =1.0f;//volumen





	// Use this for initialization
	void Start () {
		
		
		Position = transform;//coloccamos posision
		
		
	}




	void OnCollisionEnter2D(Collision2D collision)
    {
      
		if (audio && collision.gameObject.tag == "jugador") {//si ahy audio llamamo al sonido
			AudioSource.PlayClipAtPoint (audio, Position.position, volumen);//pasamos tres referencias 


			//Audio,posision y volumen


		}
      


    }



}
