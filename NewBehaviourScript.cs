/*
 Script que controla
 el texto del score en gui
 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour {


	public Text t;
	healplayer h;


	void Update () {
		t.text="Score:"+healplayer.Score;
	
		
	
	}
}
