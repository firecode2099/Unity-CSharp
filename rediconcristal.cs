using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;


public class rediconcristal : MonoBehaviour {

    //variables 

    public AudioClip audio = null;//objeto donde colocar el audio
    protected Transform Position;//posision sino no suena
    public float volumen = 1.0f;//volumen



    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            AudioSource.PlayClipAtPoint(audio, Position.position, volumen);//pasamos tres referencias 
            
            Destroy(gameObject);

        }

    }







	// Use this for initialization
	void Start () {
        Position = transform;//coloccamos posision
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
