using UnityEngine;
using System.Collections;

public class nodestriur : MonoBehaviour {
	 public GameObject go;
	public Transform t; 
	healplayer h;
	void Awake () {
		DontDestroyOnLoad (this);
		}



	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {


		if(healplayer.healt==0f){

			Destroy (go);
		}

	}
}
