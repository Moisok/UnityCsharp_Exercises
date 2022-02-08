using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoisesCDFEjercicio5 : MonoBehaviour
{
    // Start is called before the first frame update
    public int valor1;
    public int valor2;
    public int valor3;
    void Start()
    {
        if (valor1 > valor2 && valor1 > valor3){
            Debug.Log("El mayor es " +  valor1);
        }
        else if (valor2 > valor1 && valor2 > valor3){
            Debug.Log("El mayor es " + valor2);
        }
        else if (valor3 > valor2 && valor3 > valor1){
            Debug.Log("El mayor es " + valor3);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
