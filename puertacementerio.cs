using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class puertacementerio : MonoBehaviour {
    bool a = false;

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.W) && a == true)
        {

            SceneManager.LoadScene("3-1");

        }


    }
    void OnTriggerEnter2D()
    {


        a = true;

    }


}
