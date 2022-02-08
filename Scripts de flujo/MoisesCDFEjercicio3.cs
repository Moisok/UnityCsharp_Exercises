using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoisesCDFEjercicio3 : MonoBehaviour
{
    // Start is called before the first frame update
    public double divisor;
    public double dividendo;

    void Start()
    {
        if (divisor != 0){
            Debug.Log("Resultado: " + dividendo/divisor);
        }
        if (divisor == 0){
            Debug.Log("Lo siento, no puedo dividir");
        }    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
