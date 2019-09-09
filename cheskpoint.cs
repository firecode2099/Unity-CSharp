using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class cheskpoint : MonoBehaviour
{

    public GameObject go;
    static string s;
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            s = SceneManager.GetActiveScene().name;
            PlayerPrefs.SetString("pantalla",s);
            Instantiate(go);
            Destroy(gameObject);
        }
    }

    void Start()
    {
       
    }
    void Update()
    {


        

    }
   public static string getPosition()
    {


        return PlayerPrefs.GetString("pantalla"); 

    }
}
