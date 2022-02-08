using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoisesCDFEjercicio2 : MonoBehaviour
{
    // Start is called before the first frame update
    public int valor1;
    public int valor2;

    void Start()
    {
       if (valor1 == 0){
           Debug.Log("El resultado es 0");
       }
       if (valor1 != 0){
           Debug.Log("El resultado es " + (valor1*valor2));
       }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
