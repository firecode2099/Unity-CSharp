//pausamos el juego

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class pause : MonoBehaviour {

	
	
	// Update is called once per frame
	void Update () {
		
		if(Input.GetKey(KeyCode.F)){

			Time.timeScale = 1;
		}
		if(Input.GetKey(KeyCode.P)){

			Time.timeScale = 0;
		}
        



	}
}
