using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoisesEjercicio8 : MonoBehaviour
{
    // Start is called before the first frame update
    public int valor1 = 0;
    public int valor2 = 0;
    void Start()
    {
        Debug.Log("Resultados");
        Debug.Log("Suma: " + (valor1 + valor2));   
        Debug.Log("Resta: " + (valor1 - valor2));
        Debug.Log("Multiplicacion: " + (valor1 * valor2));
        Debug.Log("Division: " + (valor1/valor2));
        Debug.Log("Resto: " + (valor1%valor2)); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
