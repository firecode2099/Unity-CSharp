using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manzana : MonoBehaviour {

    //variables 
    public GameObject man, go;
    public AudioClip audio = null;//objeto donde colocar el audio
    protected Transform Position;//posision sino no suena
    public float volumen = 1.0f;//volumen


    // Use this for initialization
    void Start()
    {
        
        Position = transform;//coloccamos posision

    }



    void OnCollisionEnter2D(Collision2D collision)
    {

        if (audio == true)
        {
            print("musica");
            AudioSource.PlayClipAtPoint(audio, Position.position, volumen);//pasamos tres referencias 


        }

        if (collision.gameObject.tag == "jugador")

        {//si ahy audio llamamo al sonido
          Destroy(man);

            healplayer.Score += 100;

            //Audio,posision y volumen


        }

     


    }




}
