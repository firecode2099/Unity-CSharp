using UnityEngine;
using UnityEngine.UI;

using System.Collections;

public class dialogonpc1 : MonoBehaviour {


	public  string npc3="Hol soy el pescador,\n andas en busca de algo?";
	public Text text;




	void  Update () {

	}

	void OnCollisionEnter2D(){
		
		text.text = npc3;


	}
	void OnCollisionExit2D(){
		
		text.text = null;

	}







}