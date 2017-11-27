using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class cuenta : MonoBehaviour {


	public Text countText;
	private int count;


	// Use this for initialization
	void Start () {
		count = 0;
		countText.text = "arranque:" + count.ToString ();

	}



	 void Update (){

			if(Input.GetKeyUp(KeyCode.F)){
			count = count +1;
			countText.text = "marcha" + count.ToString ();


		}


		
		
	

	}

}
