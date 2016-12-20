using UnityEngine;
using System.Collections;

public class Nave : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "Escenario") {
			Destroy (gameObject);
		}
	}
}