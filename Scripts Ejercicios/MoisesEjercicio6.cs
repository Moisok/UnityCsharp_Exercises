using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoisesEjercicio6 : MonoBehaviour
{
    // Start is called before the first frame update

    public int valor1;
    public int valor2;

    void Start()
    {
       int multiplicacion = valor1*valor2;
       Debug.Log("Resultado =" + multiplicacion); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
