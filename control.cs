using UnityEngine;
using System.Collections;

public class control : MonoBehaviour {

	public GameObject go;

    float velo =15f;
    float jump=30f; 

	// Update is called once per frame
	void Update () {
		/*
        if (Input.GetKey(KeyCode.Escape))
        {

            Application.Quit();

        }
		*/
        
		if(Input.GetKey(KeyCode.D)){

			go.transform.Translate( new Vector3(-velo/5,0,0)*Time.deltaTime);
           
            transform.Translate(new Vector3(velo, 0, 0) * Time.deltaTime);
			
		}
		
		if(Input.GetKey(KeyCode.A)){
            go.transform.Translate(new Vector3(velo / 5, 0, 0) * Time.deltaTime);

            transform.Translate(new Vector3(-velo, 0, 0) * Time.deltaTime);
			

		}

		if(Input.GetKey(KeyCode.Space)){

            transform.Translate(new Vector3(0, jump, 0)* Time.deltaTime);


		}



}
}