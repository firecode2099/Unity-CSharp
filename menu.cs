using UnityEngine;
using UnityEngine.UI;

using System.Collections;

public class menu : MonoBehaviour {

	public int contador;
	public Text text;



	// Use this for initialization
	void Start () {
		contador=0;
		text.text="Contador: "+contador.ToString();

	}
	
	// Update is called once per frame
	void Update () {
	
		if(contador==15){
			Application.LoadLevel("end");
		}
	}


	//cuidado colisiones 2d es asi ojo
	
	void OnCollisionEnter2D(){
		contador=contador+=1;
		text.text="Contador: "+contador.ToString();

		print ("has colisionado");
		
	}




}
