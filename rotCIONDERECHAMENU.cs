using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotCIONDERECHAMENU : MonoBehaviour
{

    //    public  Animator ani;

    public GameObject go;
    float rot = 3.0f;
    
    void Update()
    {
        //rot = Time.deltaTime;

        if (Input.GetKey(KeyCode.D))
        {
            //          ani.SetBool("rotar", true);
            transform.Rotate(new Vector3(0, 0, -rot));
        }

        if (Input.GetKeyUp(KeyCode.D))
        {
            //        ani.SetBool("rotar", false);

        }



        /*
        if (Input.GetKey(KeyCode.D))
        {

            ani.SetBool("rotar", true);

            if (Input.GetKeyDown(KeyCode.D))
            {
                ani.SetBool("rotar", true);


            }

        }
        else {

            ani.SetBool("rotar", false);

        }

        */
    }

}