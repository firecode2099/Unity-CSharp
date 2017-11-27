using UnityEngine;
using System.Collections;

public class mwnu : MonoBehaviour {
public	int x=25;
	public string ss;
	void  Update () {
	

		
		if(Input.GetKey(KeyCode.F)){
			x++;
			
		}


	}


	void OnGUI(	) {



		//mostramos string porpantalla
		//GUI.Box(new Rect(10, 30, 100, 20),x.ToString());
		//GUI.color = Color.cyan;
		//GUI.backgroundColor =Color.blue ;
		//llamamos a funcion clickmouse si presionamos
		if(GUI.Button(new Rect (200, 200, 100, 20), "start")==true ){
			OnMouseDown();

		}


	}

	void OnMouseDown(){
		
		
		//GUI.Button(new Rect(10, 70, 100, 20),"start");
		Application.LoadLevel ("a");
		
	}


}
