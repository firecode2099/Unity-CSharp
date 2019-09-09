using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

	

/*

Texto prueba mostramos texto en pantalla pero con cierta velocidad.
no funciona con file.io este metodo solo con string!!!
 
 Bien creamos script para leer desde archivo externo!.
 * 
 * -Creamos un path
 * -Creamos string y pasamos el metodo System.IO.File.ReadAllText(path);
   -Luego el texto lo pasamos al ui y lo combertimos a ToString()!
 * -Usamos Try and cath por excepxion
 */



public class textohablar2 : MonoBehaviour
{

    string text3 = " who are you?";
    
    int i;

    public Text t;
    string path = "Assets/texto/prueba.doc";

    // Use this for initialization
    void Start()
    {


        //hacvecmos lamada a funcion
     StartCoroutine(e());
        
    
    }



    //mostramos texto en pantalla
    IEnumerator e(){
		
		for(i=0;i<text3.Length;i++){

			t.text += " " +text3[i];

			yield return new WaitForSeconds(0.20f);


		
		}

	}


}

