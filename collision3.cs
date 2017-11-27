
using UnityEngine.UI;

using UnityEngine;
using System.Collections;

public class collision3 : MonoBehaviour {


	public int cont;
	public Text text;
	public Text text2;

	void OnCollisionEnter(){



		GetComponent<Renderer>().material.color = Color.blue;
		
		cont=cont +1;
		text.text = "sumamos" + cont.ToString ();
		
	}
	
	// Use this for initialization
	void Start () {
		cont=cont +1;
		text.text = "sumamos" + cont.ToString ();

	}
	
	// Update is called once per frame
	void Update () {
		if(cont==2){
			Application.LoadLevel("end");

		}
	}
}
