using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ataquenemigolagarto : MonoBehaviour
{

    int contador = 0;
    public GameObject orb;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Finish")
        {
            print("tocamos");
            Destroy(gameObject);

            Instantiate(orb, new Vector2(gameObject.transform.position.x, gameObject.transform.position.y), Quaternion.identity);
        }
       
    }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        contador ++;
        if (contador > 100)
        {

            gameObject.GetComponent<Animator>().SetBool("ataque", true);
            contador = 0;
        }
        else {
            gameObject.GetComponent<Animator>().SetBool("ataque", false);
        }


    }
}
