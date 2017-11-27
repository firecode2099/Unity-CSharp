/*

escript para 
items collision 3d tanto como 2d


*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class items : MonoBehaviour {



	public GameObject go;
    //para colision 2d
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "jugador")
        {
            Destroy(go);
            healplayer.Score += 10;

        }

    }

    //para colision 3d
    void OnCollisionEnter(){

		DestroyObject (go);
		healplayer.Score++;
	}




	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}




}
