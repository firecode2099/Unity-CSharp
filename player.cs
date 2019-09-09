
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {

    
    
        

    public Animator ani;
    //public GameObject fondomover;

    bool piso = true;
	// Use this for initialization
	void Start () {
        
        
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.F))
        {

            piso = true;
           
            ani.SetBool("cambio", true);
            ani.SetBool("standinvertido", false);


        }
        else
        {

            ani.SetBool("cambio", false);


        }






        if (piso == false)
        {

            ani.SetBool("salto", true);
            ani.SetBool("caminar", false);

        }
        else {
            ani.SetBool("salto", false);
            
            
        }
       

        if(Input.GetKey(KeyCode.D)){

            piso = true;
      //      fondomover.transform.Translate(-0.1f,0,0);
           
            transform.Translate(0.2f,0,0);
            ani.SetBool("caminar",true);
            ani.SetBool("standinvertido", false);
        

        }else{

            ani.SetBool("caminar", false);
        

        }


        if (Input.GetKey(KeyCode.S))
        {

            piso = true;
            ani.SetBool("sentado",true);

        }
        else
        {
            ani.SetBool("sentado", false);


        }





        if (Input.GetKey(KeyCode.A))
        {

            piso = true;
            ani.SetBool("caminarinv", true);
            //fondomover.transform.Translate(0.1f, 0, 0);
            transform.Translate(-0.2f, 0, 0);


        }
        else {

            ani.SetBool("caminarinv", false);

        }



        if (Input.GetKey(KeyCode.Space))
        {
            //ani.SetBool("salto",true);

            piso = false;
            transform.Translate(0, 0.2f, 0);


        }


        
	}
  
}
