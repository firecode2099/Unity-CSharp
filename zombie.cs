using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class zombie : MonoBehaviour
{

    private bool destruir=false;
    private static  bool moverCamara = false;
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Finish")
        {
            moverCamara = true;
            gameObject.GetComponent<Animator>().SetBool("e", true);
            destruir = true;
            
        }
        /*
        else
        {
            gameObject.GetComponent<Animator>().SetBool("e", false);
        }
        */

    }
    public void OnCollisionExit2D(Collision2D collision)
    {
            gameObject.GetComponent<Animator>().SetBool("e", false);
            moverCamara = false;

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (destruir)
        {
            moverCamara=false;
        }
    }
    public void explotar() {
        Destroy(gameObject);

    }
    public static bool getMover()
    {
        return moverCamara;

    }
}
