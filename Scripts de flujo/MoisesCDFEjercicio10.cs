using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoisesCDFEjercicio10 : MonoBehaviour
{
    // Start is called before the first frame update
    public int valor1;

    public int valor2;

    void Start()
    {
        
        if (valor1 > 0 && valor2 > 0){
            Debug.Log("Los numeros son positivos");
        }
        else if (valor1 > 0 || valor2 > 0){
            Debug.Log("Uno de los numeros es positivo");
        }
        else{
            Debug.Log("Los numeros son negativos");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
