//Invoke("ob", 1);


using UnityEngine;
using System.Collections;

public class llamarobjeto : MonoBehaviour {
	public float x;
	public float y;
	public float z;
	public GameObject target;




	// Use this for initialization
	void Start () {
		//Invoke("ob", 1);
		if(Input.GetKey(KeyCode.F)){
			
			Invoke("ob",1);

		}
		


	}
	
	// Update is called once per frame
	void Update () {
	


	}


		//funcion objeto

	void ob(){
    

		Instantiate(target, new Vector3(x, y, z), Quaternion.identity);



	}

}
