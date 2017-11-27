using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controllegacy2d : MonoBehaviour {


	public Animation ani;
	// Use this for initialization
	void Start () {
		ani = gameObject.GetComponent<Animation> ();
	}
	
	// Update is called once per frame
	void Update () {

		ani.Play ();

	}
}
