using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlcamara3d : MonoBehaviour
{
    
    public GameObject player,pasos,correr,t;
    public GameObject light;
    int liht_=0;
    
     //Accedemos a propiedad camera
    private Camera cam;
    float x, y, y2;



    void Awake()
    {
        //usamos para controlar  skybox
        cam = GetComponent<Camera>();
        light.SetActive(false);
        //pasos.SetActive(false);
       // correr.SetActive(false);
    }


    void Start()
    {


    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Cursor.visible=false;


        //ponemos de noche dependiendo del getter
        if (l.get_x() == 2000)
        {

            //cam.clearFlags = CameraClearFlags.SolidColor;
        }

        //ponemos de dia
        if (l.get_x() == 4000)
        {

          //  cam.clearFlags = CameraClearFlags.Skybox;
        }


        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        if (x > 0)
        {
            player.transform.Rotate(0, 4, 0);
        }
        if (x < 0)
        {
            player.transform.Rotate(0, -4, 0);
        }
        if (y > 0)
        {
            
            player.gameObject.GetComponent<Animator>().SetBool("walk",true);
            pasos.SetActive(true);
            player.transform.Translate(0, 0, 0.1f);
        }else{
             player.gameObject.GetComponent<Animator>().SetBool("walk",false);
             pasos.SetActive(false);

        }
         if (Input.GetKey(KeyCode.LeftShift))
        {
            
            player.gameObject.GetComponent<Animator>().SetBool("run",true);
            correr.SetActive(true);
            player.transform.Translate(0, 0, 0.2f);
        }else{
             player.gameObject.GetComponent<Animator>().SetBool("run",false);
             correr.SetActive(false);
        }
        if (y < 0)
        {
            player.gameObject.GetComponent<Animator>().SetBool("walkback",true);
            player.transform.Translate(0, 0, -0.1f);
           
            //transform.Translate(0, 0, -1);
        }else{

            player.gameObject.GetComponent<Animator>().SetBool("walkback",false);
           
        }
       if (x > 0)
        {
            player.gameObject.GetComponent<Animator>().SetBool("walkright",true);
            
            //transform.Translate(0, 0, -1);
        }else{
          player.gameObject.GetComponent<Animator>().SetBool("walkright",false);

        }
        if (x < 0)
        {
//            player.gameObject.GetComponent<Animator>().SetBool("walkleft",true);
            
        
        }else
        {
  //        player.gameObject.GetComponent<Animator>().SetBool("walkleft",false);

        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            light.SetActive(true);
            liht_+=1;
            //transform.Translate(1, 0, 0);
           t.SetActive(true);

        }
            
    
    
                if (liht_>1 && (Input.GetKeyUp(KeyCode.Space)))
                {
                  

                   light.SetActive(false);
                   t.SetActive(false);
                   liht_=0;
                }
             
        


        
      
      
    }
}
