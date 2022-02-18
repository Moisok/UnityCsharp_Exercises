using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HolaMundo : MonoBehaviour {

	public int puntos = 10;

	public  float nivel = 1.0f;

	public  string nombre = "User";

	public bool mujer = false;

	int cont = 0;

	//public  bool activado = false;

	// Use this for initialization
	void Start () {
		//Debug.Log("Hola Mundo");
		/*if (nivel < 5.5f && puntos <=50){

			puntos++;

		}

		if (!mujer) Debug.Log("Soy un hombre");
		else Debug.Log("Soy una mujer");*/

		/*Debug.Log("Puntos:"+puntos);
		
		Debug.Log("Nivel:"+nivel);*/

		/*for (cont = 0; cont < 5 ; cont++){
			Debug.Log("Creado enemigo numero: " + cont);
		}*/

		/*while (puntos <= 30)
		{
			Debug.Log("Acumulando puntos..." + puntos);
			puntos++;
		}*/
		do {
			Debug.Log("Acumulando puntos..." + puntos);
			puntos++;
		}
		while(puntos <= 30);

		
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log("Hola mundo en el update");
	}
}
