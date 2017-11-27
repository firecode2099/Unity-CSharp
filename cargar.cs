using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cargar : MonoBehaviour {

	 public GameObject go;

	 void OnCollisionEnter2D(){
		//Destroy (go);
		Application.LoadLevel("1");
        healplayer.healt -= 1;



    }


}
