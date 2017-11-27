using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class entradapuerta : MonoBehaviour {



    
    // Update is called once per frame
    void Update()
    {

    

    }
    void OnCollisionEnter2D()
    {


        SceneManager.LoadScene("3-2");


    }



}
