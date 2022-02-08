using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoisesCDFEjercicio9 : MonoBehaviour
{
    // Start is called before the first frame update
    public int valor1 = 0;
    public int valor2 = 0;
    void Start()
    {
        if (valor1 < 0 && valor2 < 0){
            Debug.Log("Ambos numeros son negativos");
        }else{
            Debug.Log("No son negativos");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
