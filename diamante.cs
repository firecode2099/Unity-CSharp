using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class diamante : MonoBehaviour {

	public GameObject go;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "jugador")
        {
            Destroy(go);
            healplayer.Score += 1000;

        }

    }


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
