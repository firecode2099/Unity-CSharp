using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Telereansporter : MonoBehaviour
{

    public static bool Tele { set; get; }
    public void Start()
    {
        Tele = true;
    }

    public  void setActiva()
    {
        Tele = false;
        Destroy(gameObject);
      
    }
    
}
