using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoisesCDFEjercicio15 : MonoBehaviour
{
    // Start is called before the first frame update

    public int numero;
    public int cantidad;    
    int contador = 0;

    void Start()
    {
        for (int i=0;i<cantidad;i++){
            Debug.Log(numero);
        }

        while (contador<cantidad){
            Debug.Log(numero);
            contador++;
            
        }
    }
        
    // Update is called once per frame
    void Update()
    {
        
    }
}
