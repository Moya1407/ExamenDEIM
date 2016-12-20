using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Contador : MonoBehaviour {

	public int golesA = 0;
	Text texto;

	void Start(){
		texto = GetComponent<Text> ();
	}

	public void suma_golesA (int cantidad){
		golesA = golesA + cantidad; //monedas += cantidad;
		if (golesA < 0) {
			golesA = 0;
		}
		texto.text = golesA.ToString ();
	}
}