//script para activar componente de imagen
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class activar : MonoBehaviour {

	public Image im;


	void Awake(){
		im.enabled = false;

	
	}


	// Use this for initialization
	void Start () {

	im  =  GameObject.Find("canvas").GetComponent<Image>();

	}
	
	// Update is called once per frame
	void Update () {
		
		if(Input.GetKey(KeyCode.F)){
			im.enabled = true;
			print ("presionamos f");
		}
	
	}
}
