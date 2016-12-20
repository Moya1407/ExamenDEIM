using UnityEngine;
using System.Collections;

public class Player2 : MonoBehaviour {
	public float velocidad = 100f;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.A)) {
			Debug.Log ("A");
			GetComponent<Rigidbody2D> ().AddForce (Vector2.left*velocidad);
		}

		if (Input.GetKey (KeyCode.D)) {
			Debug.Log ("D");
			GetComponent<Rigidbody2D> ().AddForce (Vector2.right*velocidad);
		}

		if (Input.GetKey (KeyCode.W)) {
			Debug.Log ("W");
			GetComponent<Rigidbody2D> ().AddForce (Vector2.up*velocidad);
		}

		if (Input.GetKey (KeyCode.S)) {
			Debug.Log ("S");
			GetComponent<Rigidbody2D> ().AddForce (Vector2.down*velocidad);
		}
	}
}