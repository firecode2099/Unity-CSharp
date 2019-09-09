
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
 -------------------
 Control player
 --------------------

*/

public class joy : MonoBehaviour
{


    //Control
    private static float h;
    private static float v;
    private bool derecho = true;
    
    //JOY
    public static bool bd, bd_1, bd_2, bd_3, bd_4;

    //Variables
     public Animator ani;
     static float time = 0f;
	 float velocidad=0.2f;
     float salto = 1/4f;
     float saltoi = 1f;
     float fondomover = 1 / 50f;
     bool flotar=false;
     bool agachado = false;
     public  GameObject menupausa;
     Vector3 check;

    //Control
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "piso")
        {
            flotar = false;
            ani.SetBool("salto", false);
        }
        if (collision.gameObject.tag == "Chesckpoint")
        {
            check = gameObject.transform.position;
            collision.gameObject.SetActive(false);
        }
        if (collision.gameObject.tag == "cargador")
        {
            gameObject.transform.position = check;
        }
        if (collision.gameObject.tag == "jdisparo")
        {
            universal.setEnergia(50);
        }
        if (collision.gameObject.tag == "enemigo")
        {
            flotar = false;
            ani.SetBool("contacto", true);
            universal.setEnergia(50);
            
            deadplayer();
        }
    }
    //ColissionExit
    public void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "piso")
        {
            flotar = true;
            ani.SetBool("caminar", false);
            ani.SetBool("caminarinv", false);
            ani.SetBool("salto", true);
        }
    }

    //Joy input
    public void joyInput()
    {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");
        bd = Input.GetKey(KeyCode.Joystick1Button0);
        bd_1 = Input.GetKey(KeyCode.Joystick1Button1);
        bd_2 = Input.GetKey(KeyCode.Joystick1Button2);
        bd_3 = Input.GetKey(KeyCode.Joystick1Button3);
        bd_4 = Input.GetKey(KeyCode.Joystick1Button4);

    }
    void Update(){

        correrDisparando();
        joyInput();

        if (activar.getContador()>500 || SceneManager.GetActiveScene().name!="1" && !Telereansporter.Tele == true)
        {

            completo();
        }
        pausa();
        if (Input.GetKey(KeyCode.Joystick1Button8))
        {

            Application.Quit();
        }
        Cursor.visible = false;

        ActivePlayer();
    }



    //Complete Function
   public void completo()
    {
        correrDisparando();
        correr();
        correi();
        saltar();
        disparo();
        i();
        Cr();
        Cri();


    
    }

    //correr
    public void Cr()
    {
        bool x = false;
        derecho = true;
        if ( derecho && bd_4)
        {
            x = true;

            ani.SetBool("cruzado", true);

            if (derecho &&  x && bd_3)
            {
                ani.SetBool("fuegocruzado", true);

            }
            
            else {

                ani.SetBool("fuegocruzado", false);
            }
            
        }
        else
        {
            x = false;
            ani.SetBool("cruzado", false);
        }
    }

    //Inverse character control
    public void Cri()
    {
        flotar = false;
        bool x = false;
        derecho = false;
        if ( !derecho && bd_4)
        {
             x = true;
            ani.SetBool("cruzadoi", true);


            if (!derecho && x && bd_3)
            {

                ani.SetBool("fuegocruzadoi", true);
            }
            else {
                ani.SetBool("fuegocruzadoi", false);

            }

        }
        else
        {
            ani.SetBool("cruzadoi", false);
        }
    }


    
    //Floor contact
    public void piso()
    {

        if (v < 0 && bd_1)
        {
            derecho = true;
            ani.SetBool("piso", true);
            transform.Translate(new Vector2(velocidad+1, 0));
            


        }
        else
        {
            ani.SetBool("piso", false);
        }
    }



    //correr
    public void correr()
    {
        
        if (h > 0)
         {
            flotar = false;
            derecho = true;
            ani.SetBool("caminar", true);
            transform.Translate(new Vector2(velocidad, 0));
            ani.SetBool("inverso", false);


        }
         else {
             ani.SetBool("caminar", false);
         }
     }

    
    //agacharse
     void agachar() {
         

        if (Input.GetKeyDown(KeyCode.S) || v < 0)
        {
            agachado = true;
            ani.SetBool("sentado", true);
          
        }
        else
        {
            ani.SetBool("sentado", false);

        }


        if (Input.GetKeyDown(KeyCode.S) && Input.GetKeyDown(KeyCode.Joystick1Button2))
        {
            agachado = true;
            ani.SetBool("crowling", true);

        }
        else
        {
            ani.SetBool("crowling", false);

        }

       
        if (v < 0 && Input.GetKeyDown(KeyCode.Joystick1Button2))
        {
            agachado = true;
            ani.SetBool("crowling", true);

        }
        else
        {
            ani.SetBool("crowling", false);

        }

    }

    //salto
    public   void saltar()
    {
        if (flotar)
        {
            ani.SetBool("salto", true);
        }
        else {
            ani.SetBool("salto", false);
        }

        if (h > 0 && Input.GetKeyDown(KeyCode.Joystick1Button2))
        {
            flotar = true;
            
            transform.Translate(new Vector2(0, 5)*Time.smoothDeltaTime);

        }

        if (!flotar && Input.GetKeyDown(KeyCode.Joystick1Button2))
        {
            flotar = true;
            transform.Translate(new Vector2(0, 5));
            ani.SetBool("salto", true);

        }
        else {
            flotar = false;
            ani.SetBool("salto", false);
        }

        if (Input.GetKey(KeyCode.Joystick1Button2))
        {
            flotar = true;
           transform.Translate(new Vector2(0, salto));
  
    }
        else
        {
       
            transform.Translate(new Vector2(0, 0));
        }

        if ( Input.GetKeyDown(KeyCode.Space))
        {
            flotar = true;
            transform.Translate(new Vector2(0, 5));
        }


    }

    //saltoi
    void saltari(){
        
        
        //jumpi
        if (h < 0 && Input.GetKey(KeyCode.Joystick1Button2))
        {

            flotar = true;
            ani.SetBool("caminarinv", false);
            ani.SetBool("jumpi", true);
            transform.Translate(new Vector2(0, saltoi));

        }
        else
        {

            ani.SetBool("caminarinv", true);
            ani.SetBool("jumpi", false);
            transform.Translate(new Vector2(0, 0));

        }

    }


    //correiz
    void correi() {
        derecho = false;
        flotar = false;
        if (h < 0 && Input.GetKey(KeyCode.Joystick1Button3))
        {
            ani.SetBool("di", true);
            
        }
        else
        {
            ani.SetBool("di", false);
        }


        if (h < 0)
        {


            flotar = false;
            
            ani.SetBool("caminarinv", true);
            
            transform.Translate(new Vector2(-velocidad, 0));

        }
        else
        {
            
            
            ani.SetBool("caminarinv", false);

        }
        


    }
   
    

    //pausa menu
    void pausa()
    {
        int pausa = 0;

        if (Input.GetKey(KeyCode.Return))
        {
            menupausa.SetActive(true);
            pausa++;
            Time.timeScale = 0;
        }

        if ( Input.GetKey(KeyCode.Joystick1Button9))
        {
            menupausa.SetActive(true);
            pausa++;
            Time.timeScale = 0;
            
        }

        if (pausa>=0)
        {
            if (Input.GetKey(KeyCode.Joystick1Button8))
            {
                pausa = 0;
                menupausa.SetActive(false);
                Time.timeScale = 1;
            }
        }




    }


    void arriba()
    {

        if (v > 0 || Input.GetKey(KeyCode.W))
        {
            gameObject.transform.Translate(0, 0.2f, 0);
        }


    }

    void abajo()
    {

        if (v < 0 || Input.GetKey(KeyCode.S))
        {
            gameObject.transform.Translate(0, -0.2f, 0);
        }


    }

   public void i()
    {
        flotar = false;
        derecho = false;
        if (h<0 )
        {
            ani.SetBool("inverso", true);
            ani.SetBool("disparo", false);
        }
        if (derecho == false && bd_3)
        {
            ani.SetBool("di", true);

        }
        else
        {
            ani.SetBool("di", false);
        }


    }

    void disparo()
    {
        derecho = true;
        if (h>0)
        {

        }

        
        if ( bd_3)
        {
            ani.SetBool("disparo", true);
            

        }
        else
        {
            ani.SetBool("disparo", false);
            
        }


        if (agachado && bd_3)
        {
            flotar = false;
            ani.SetBool("agachado", true);
        }
        else
        {
            flotar = true;
            ani.SetBool("agachado", false);

        }
    }


    public void ActivePlayer()
    {
        if (Telereansporter.Tele==true )
        {

            gameObject.GetComponent<SpriteRenderer>().enabled = false;
        }
        else {
            gameObject.GetComponent<SpriteRenderer>().enabled = true;
            

        }
    }
    public void correrDisparando()
    {
        derecho = true;
        flotar = false;
        if (bd_3 && h > 0)
        {
            ani.SetBool("disparo", false);
            ani.SetBool("caminardisparo", true);
            
        }
        else {
            ani.SetBool("caminardisparo", false);
        }
        
    }
    public void deadplayer()
    {
        if (universal.getEnergia() < 1)

        {
            ani.SetBool("dead", true);
        }
        else {
            ani.SetBool("dead", false);
        }
    }
    public void destroyplayer()
    {
        SceneManager.LoadScene("Dead");
        Destroy(gameObject);

    }
}





