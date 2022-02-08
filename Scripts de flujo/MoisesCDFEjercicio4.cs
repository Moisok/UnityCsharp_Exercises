using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoisesCDFEjercicio4 : MonoBehaviour
{
    public double divisor;
    public double dividendo;

    void Start()
    {
        if (divisor != 0){
            Debug.Log("Resultado: " + dividendo/divisor);
        }
        else{
            Debug.Log("Lo siento, no puedo dividir");
        }    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
