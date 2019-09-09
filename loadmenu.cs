using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class loadmenu : MonoBehaviour {

    public  int con;

	
      void Update () {
          con++;
        Cursor.visible = false;
        if(con==200f){
            print(con);

            SceneManager.LoadScene("idioma");
       
        }

    }

}
