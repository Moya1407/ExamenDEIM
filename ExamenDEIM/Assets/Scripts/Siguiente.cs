using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Siguiente : MonoBehaviour {
	GameObject txt_golesA;
	Contador ctrl_golesA;
	GameObject txt_golesR;
	ContadorR ctrl_golesR;

	// Use this for initialization
	void Start () {
		txt_golesA = GameObject.Find ("TextoGolesA");
		ctrl_golesA = txt_golesA.GetComponent<Contador> ();
		txt_golesR = GameObject.Find ("TextoGolesR");
		ctrl_golesR = txt_golesR.GetComponent<ContadorR> ();
	}

	void Update () {
			if (ctrl_golesA.golesA == 5) {
			SceneManager.LoadScene (1);
		}
			if (ctrl_golesR.golesR == 5) {
				SceneManager.LoadScene (1);
			}
	}
}
