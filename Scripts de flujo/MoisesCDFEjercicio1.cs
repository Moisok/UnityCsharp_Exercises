using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoisesCDFEjercicio1 : MonoBehaviour
{
    // Start is called before the first frame update
    public int valor;
    void Start()
    {
        if(valor < 0){
            Debug.Log("El valor es negativo");
        }else{
            Debug.Log("El valor es positivo");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
