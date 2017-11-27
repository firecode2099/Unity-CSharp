using UnityEngine;
using System.Collections;

public class control2d : MonoBehaviour {


//	private Transform;
	public float  velocidad=2; 
	// Use this for initialization
	void Start () {
	



	}
	
	// Update is called once per frame
	void Update () {
	


		if(Input.GetKey(KeyCode.D)){

			transform.Translate( new Vector3(0,0,velocidad/100));

		}

		if(Input.GetKey(KeyCode.A)){
			
			transform.Translate( new Vector3(0,0,-velocidad/100));

			
		}

	}

}
