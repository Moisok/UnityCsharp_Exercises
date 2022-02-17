using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoisesS5 : MonoBehaviour
{
    // Start is called before the first frame update

    List <int> numeros = new List<int>{1,5,6,12,32,45,67,43,54,67};
    bool impar = false;
    void Start()
    {
        for (int i=0; i<numeros.Count ; i++){
            if(numeros[i]%2!=0){
                Debug.Log("Numero impar: " + numeros[i] + " se encuentra en posicion " + i);
                numeros.Remove(i);
                impar = true;
            }
        }

        if (!impar){
            Debug.Log("No hay numeros impares en la lista");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
