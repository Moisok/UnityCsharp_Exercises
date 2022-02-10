using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoisesCDFEjercicio19 : MonoBehaviour
{
    // Start is called before the first frame update
    public int numero;

    int numero2;
    int cifra = 0;
    
    void Start()
    {
        numero2 = numero;
        while (numero2 != 0){
            numero2 = numero2 / 10;
            cifra++;
        }

        if (numero < 0){
            Debug.Log("El numero introducido tiene " + cifra + " cifras (ES NEGATIVO)");
        }else{
            Debug.Log("El numero introducido tiene " + cifra + " cifras");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
