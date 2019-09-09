using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemigos : MonoBehaviour
{
    
    public  int energia { set; get; }

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void setAtaque()
    {

    }


    public void setEstadoEnemigo(GameObject go, int ener)
    {
        energia = ener;
        if (energia < 1)
        {
            
            Destroy(go);
        }
        
    }
    public void setAni_True(GameObject go,string ani)
    {
        go.GetComponent<Animator>().SetBool(ani,true); 
    }
    public void setAni_False(GameObject go, string ani)
    {
        go.GetComponent<Animator>().SetBool(ani, false);
    }

}
