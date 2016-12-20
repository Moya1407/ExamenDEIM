using UnityEngine;
using System.Collections;

public class GolesA : MonoBehaviour {
	private Rigidbody2D rb;
	GameObject txt_golesA;
	Contador ctrl_golesA;

	// Use this for initialization
	void Start () {
		txt_golesA = GameObject.Find ("TextoGolesA");
		ctrl_golesA = txt_golesA.GetComponent<Contador> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "Pelota") {
			ctrl_golesA.suma_golesA (1);
		}
	}
}