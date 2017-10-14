using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WASD : MonoBehaviour {
	int monedas;
	Rigidbody rb;
	public Text puntos;
	public float velocidad;
	public Text win;

	public void OnTriggerEnter (Collider other){
		Destroy (other.gameObject);
		monedas++;
		sumaMoneda ();
		if (monedas >= 11) {
			win.gameObject.SetActive (true);
		}
	}
	private void sumaMoneda(){
		puntos.text = "Monedas: "+ monedas + "/11";

	}

	public void Awake(){
		rb = GetComponent<Rigidbody>();
		monedas = 0;
		sumaMoneda ();
		win.gameObject.SetActive (false);

	}
	public void FixedUpdate(){
		float ws;
		float ad;
		ws = Input.GetAxis ("Horizontal");
		ad = Input.GetAxis ("Vertical");
		Vector3 fuerza = new Vector3(ws,0,ad);

		rb.AddForce(fuerza*velocidad);
	}
}

