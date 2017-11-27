using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seguir : MonoBehaviour {

	public Transform fol;
	public float speed = 5f; 

	// Use this for initialization
	void Start () {
		speed = Time.deltaTime;
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(fol.position.x, 1.133088f, -40);
	}
}
