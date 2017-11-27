using UnityEngine;
using System.Collections;

public class reloj2 : MonoBehaviour {
	

	public cronometro t;	


	void Start () {

		t = new cronometro ();

	
	}




	void Update () {
	
	}



	
	void OnGUI(){

		
		GUI.Box(new Rect(10,10,100,20),"Time:"+t.contador.ToString());
		print (t.contador);
		
	}
	
}
