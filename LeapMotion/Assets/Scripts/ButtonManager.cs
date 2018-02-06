using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour {
	//Referenci al componente AudioSource
	private AudioSource audioSource;
	// Use this for initialization
	void Start () {
		//Recuperamos la referencia al componente audioSource
		audioSource = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Click(){
		audioSource.Play ();
	}
}
