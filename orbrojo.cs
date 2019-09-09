using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class orbrojo : MonoBehaviour
{

    int cont = 0;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

       cont++;

        if (cont>100) {

            Destroy(gameObject);
        }


    }
}
