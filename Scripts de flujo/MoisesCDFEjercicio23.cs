using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoisesCDFEjercicio23 : MonoBehaviour
{
    // Start is called before the first frame update
    public int numero;
    int contador = 0;
    void Start()
    {
        for(int i = 1;i<= numero;i++)
        {
            if((numero%i) == 0)
            {
                contador++;
            }
        }

        if(contador <= 2)
        {
            Debug.Log("El numero " + numero +  " es primo");
        }else{
            Debug.Log("El numero " + numero +  " no es primo");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
