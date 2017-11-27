using UnityEngine;
using System.Collections;

public class reconstruir : MonoBehaviour {

	    
	void Awake(){
	
		transform.Find ("player").transform.position = new Vector2 (11,10);
	
	}


	// Use this for initialization
	void Start () {

		//p1.GetComponent<player>();


	}
	
	// Update is called once per frame
	void Update () {



	}
}
