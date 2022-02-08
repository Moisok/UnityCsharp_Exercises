//Ejercicio 1.7 Uso de variables y comentarios
//Fecha 8/2/22
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoisesEjercicio7 : MonoBehaviour
{
    // Start is called before the first frame update
    public int valor1;
    public int valor2;
    public int valor3;

    void Start()
    {
        Debug.Log("¿Cual es el primer numero?");
        Debug.Log("Has introducido: " + valor1);
        Debug.Log("¿Cual es el segundo numero?");
        Debug.Log("Has introducido: " + valor2);
        Debug.Log("¿Cual es el tercer numero?");
        Debug.Log("Has introducido: " + valor3);
        int multiplicar = valor1*valor2*valor3;;
        Debug.Log("Resultado: " + multiplicar);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
