using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoisesS1 : MonoBehaviour
{

    int[] numeros = new int[5]; 

    // Start is called before the first frame update
    void Start()
    {
        
        for (int i = 0; i < numeros.Length; i++)
        {
            numeros[i] = i;
            Debug.Log("["+numeros[i]+"]");
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
