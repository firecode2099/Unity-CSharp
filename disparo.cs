using UnityEngine;
using System.Collections;

public class disparo : MonoBehaviour {

	public  float dis =1/1000;
	  float tiempovala=1.0f;

	void OnCollisionEnter(){
		Destroy(gameObject,tiempovala);

	}

	

	// Use this for initialization
	void Start () {
	


       
	               }
	
	// Update is called once per frame
	void Update () {
       
	
		if(Input.GetKeyDown(KeyCode.F)){
			
			transform.Translate( new Vector3(0,dis,0));
			
		}



	}


}
