using UnityEngine;
using System.Collections;

public class Player1 : MonoBehaviour {
	public float velocidad = 100f;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.LeftArrow)) {
			Debug.Log ("Flecha Izquierda");
			GetComponent<Rigidbody2D> ().AddForce (Vector2.left*velocidad);
		}

		if (Input.GetKey (KeyCode.RightArrow)) {
			Debug.Log ("Flecha Derecha");
			GetComponent<Rigidbody2D> ().AddForce (Vector2.right*velocidad);
		}

		if (Input.GetKey (KeyCode.UpArrow)) {
			Debug.Log ("Flecha Arriba");
			GetComponent<Rigidbody2D> ().AddForce (Vector2.up*velocidad);
		}

		if (Input.GetKey (KeyCode.DownArrow)) {
			Debug.Log ("Flecha Izquierda");
			GetComponent<Rigidbody2D> ().AddForce (Vector2.down*velocidad);
		}
	}
}