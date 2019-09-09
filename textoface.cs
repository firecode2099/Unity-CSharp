using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class textoface : MonoBehaviour {

    public Text dialogo;
     public Text t;
     string text2 = "Hola soy turok , bienvenido a mi juego";
     int i;
     int cont=0;


     void Start() {

        StartCoroutine(e());
        
     }
	// Update is called once per frame
	void Update () {
        cont++;


        if(cont==300){
             
            Destroy(dialogo);
        }
    }

    //mostramos texto en pantalla
    public  IEnumerator e()
    {
        for (i = 0; i < text2.Length; i++)
        {

            t.text += " " + text2[i];
            
            yield return new WaitForSeconds(0.10f);


        }

    }



}
