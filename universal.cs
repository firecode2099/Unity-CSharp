using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
 
 Universal control over player actions
 */

public class universal : MonoBehaviour {


    //variables
    private static int Energia = 100;
    private static int Cristal = 0;
    private static bool Dead = false;
    private static int Stage = 0;

    




    void Start () {


        //dont destroy in games loads
    
        DontDestroyOnLoad(this);
	
    }
	
	// Update is called once per frame
	void Update () {

  
  
        if (Energia == 0)
        {

            SceneManager.LoadScene("Menu");
            Energia = 100;
        }
        else
        {

        }
  
        /*
         if(Cristal==100){


             Cristal = 0;
         }

         if (Energia == 0)
         {

             SceneManager.LoadScene("1");
             Energia = 10;
         }
         else {

         }
         */
    /* 
        if (Energia==0){

            SceneManager.LoadScene("Dead");
            
            Cristal =0;

        }
      */
	}


   public static void setEnergia(int e)
    {
        Energia -= e;

    }

    public static int getEnergia()
    {
        return Energia;

    }
  
}
