using UnityEngine;
using System.Collections;

public class GolesR : MonoBehaviour {
	private Rigidbody2D rb;
	GameObject txt_golesR;
	ContadorR ctrl_golesR;

	// Use this for initialization
	void Start () {
		txt_golesR = GameObject.Find ("TextoGolesR");
		ctrl_golesR = txt_golesR.GetComponent<ContadorR> ();
	}

	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "Pelota") {
			ctrl_golesR.suma_golesR (1);
		}
	}
}