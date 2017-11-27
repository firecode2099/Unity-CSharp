using UnityEngine;
using System.Collections;

public class cargar3 : MonoBehaviour {



	public void OnCollisionEnter2D(){
		
		Application.LoadLevel("3");
        healplayer.healt -= 1;
		
		
		
	}


}
