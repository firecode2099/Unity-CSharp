using UnityEngine;
using System.Collections;

public class cronometro : MonoBehaviour {
	public Animator anima;	
	public   float contador=0f;
	public   float s=0f;
	public   float m=0f;


	void Awake () {
		DontDestroyOnLoad(this);

	}


	// Use this for initialization
	void Start () {
	

	}
	
	// Update is called once per frame
	void Update () {






		if(contador==60){
			
			contador=0;
			s++;
		}

		if(s==59){
			
			s=0;
			m++;
		}
		
		if(m==59){
			
			m=0;

		}



	}


	void OnGUI(){
		++contador;

		GUI.Box(new Rect(700,10,100,20),"Time:"+m.ToString()+":"+s.ToString()+":"+contador.ToString());
	

	}

}
