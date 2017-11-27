using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.F)){
			transform.Translate (new Vector3(5,0,0)*Time.deltaTime);
		}
	}
}
