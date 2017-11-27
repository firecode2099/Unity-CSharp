using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class vidasgui : MonoBehaviour {


	public Text t;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		t.text="x"+healplayer.life;
	}
}
