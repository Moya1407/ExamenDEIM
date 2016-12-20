using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ContadorR : MonoBehaviour {
	
	public int golesR = 0;
	Text texto;

	void Start(){
		texto = GetComponent<Text> ();
	}

	public void suma_golesR (int cantidad){
		golesR = golesR + cantidad; //monedas += cantidad;
		if (golesR < 0) {
			golesR = 0;
		}
		texto.text = golesR.ToString ();
	}
}
