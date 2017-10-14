using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCamara : MonoBehaviour {
	public GameObject jugador;
	private Vector3 posRelativa;
	// Use this for initialization

	void Start () {
		posRelativa =  transform.position - jugador.transform.position;
		//posRelativa [1] += 10; 
	}
	
	// Update is called once per frame
	void LateUpdate () {
		transform.position = jugador.transform.position + posRelativa;
		
	}
}
