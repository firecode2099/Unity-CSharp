using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


/*
 
 Start menu
 */
public class startmenu : MonoBehaviour {


    public GameObject ingles, español;


	// Update is called once per frame
	void Update () {


        if (idioma_Selector.getString() == "ingles")
        {
            ingles.SetActive(true);
            español.SetActive(false);
        }
        else {
            ingles.SetActive(false);
            español.SetActive(true);
        }


        if (Input.GetKey(KeyCode.Return) )
        {

            SceneManager.LoadScene("p2");
        }
        if (Input.GetKey(KeyCode.Return) )
        {

            SceneManager.LoadScene("p2");
        }
    }
}
