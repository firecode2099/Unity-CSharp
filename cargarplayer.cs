using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cargarplayer : MonoBehaviour {

    public static bool activado=false;
     
    public   GameObject go,animacion,avatarparado;

	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}


    public  void cargar()
    {

        if(go.active = true){

            activado = true;

        }
        
        Destroy(avatarparado);
    
        Destroy(animacion);
    
    }

}
