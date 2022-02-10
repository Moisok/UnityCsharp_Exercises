using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoisesCDFEjercicio20 : MonoBehaviour
{
    // Start is called before the first frame update
    public int numero;
    int cNumero;
    public int numero2;

    void Start()
    {
        cNumero = numero;
        for (int i=0;i<numero2;i++){
            Debug.Log(numero);
            numero = numero+ cNumero;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
