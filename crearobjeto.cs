using UnityEngine;
using System.Collections;

public class crearobjeto : MonoBehaviour {




	// Use this for initialization
	void Start () {

		if(Input.GetKey(KeyCode.M)){

			GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
			cube.AddComponent<Rigidbody>();
			cube.transform.position = new Vector3(0, 0,5);

		}
		    






	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
