using UnityEngine;
using System.Collections;

public class player1 : MonoBehaviour {
	private string status="Salud:0 \n Magia:0";
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void  Update () {

	}
		void OnGUI()	{
		if(Input.GetKey(KeyCode.F)){
			GUI.color = Color.cyan;
			GUI.Box(new Rect(10,10,100,100),status);
		}
	}



}


