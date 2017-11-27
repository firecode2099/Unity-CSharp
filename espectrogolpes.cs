/*
 Script para controlar golpes de espectro
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class espectrogolpes : MonoBehaviour {

      public Animator ani;
      float tiempo = 1f;
    
    
    
    void Update () {
        tiempo++;
        print(tiempo);
        if (tiempo == 2000f)
        {
            ani.SetFloat("golpee", 1);
            tiempo = 0f;

        }/*
        else {
            ani.SetFloat("golpee", 0);

        }
        */
	}
}
