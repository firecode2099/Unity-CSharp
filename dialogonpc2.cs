using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class dialogonpc2 : MonoBehaviour {
	
	
	//accedemos al script npc4
	public  npc4 mar;

		
	// Use this for initialization
	void Start () {

		mar = new npc4 ();
	  
	





	
	}

	void OnCollisionEnter2D(Collision2D  mar){





	}
	
	public void DoGUI(){	

	mar.OnGUI();

}

		
}