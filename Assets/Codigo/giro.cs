using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class giro : MonoBehaviour {
	public float velocidad;
	Vector3 rotate = new Vector3 (15,30,45);
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (rotate * Time.deltaTime * velocidad);
	}
}
