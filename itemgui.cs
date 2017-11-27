using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class itemgui : MonoBehaviour {

	public Text t;
	healplayer h;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		t.text="x"+healplayer.Diamante;
	}
}
