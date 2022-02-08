using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoisesCDFEjercicio6 : MonoBehaviour
{
    // Start is called before the first frame update
    public int valor;
    int contador = 0;
    void Start()
    {
        while (contador < valor){
            Debug.Log(contador);
            contador++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
