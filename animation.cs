/*script para controlar animacion por legacy
 recordar que no debe tener aimatocomo componente
  
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animation : MonoBehaviour {

	healplayer h;
	public Animation an;

	// Use this for initialization
	void Start () {
		//obtenemos el component de animation
		an = gameObject.GetComponent<Animation> ();
	}


	void OnCollisionEnter2D(){
		an.Play ();
		//healplayer.healt--;

			//Application.LoadLevel ("1-2");

	}




}
