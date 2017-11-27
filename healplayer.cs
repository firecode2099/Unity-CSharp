/*
 energia del player1
 tenemos:
 heal=energia
 Score=puntos
 Diamantes =diamantes de colleccion
 
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class healplayer : MonoBehaviour {


    public Animator ani;

	//estoy accediendo desde otra funcion
	public static float healt = 3f;
	public static float life = 3f;

	public static float Score = 0.0f;
	public static float Diamante = 0.0f;



	void Update(){
        

        if (life==0f){
           /*
            healt = 0.0f;
           life = 0.0f;
           Score = 0.0f;
           Diamante = 0.0f;
           */
             SceneManager.LoadScene("dead");
           Application.LoadLevel("dead");
		}
        /*
		if (healt==0.0f){

			life -= 1;
		}
			
	*/
	   }

    
        void    OnCollisionEnter2D(Collision2D collision)
    {


		if (collision.gameObject.tag == "bomba")
		{
			ani.SetFloat("dañar", 1);

		}

        if (collision.gameObject.tag == "enemy")
        {
            ani.SetFloat("dañar", 1);
            
        }
        else
        {
            ani.SetFloat("dañar", 0);

        }

    }

    

}
