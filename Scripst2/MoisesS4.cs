using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoisesS4 : MonoBehaviour
{
    // Start is called before the first frame update

    int[] numeros = new int[10];
    bool par = false;

    void Start()
    {

        numeros[0]=23;
        numeros[1]=56;
        numeros[2]=34;
        numeros[3]=89;
        numeros[4]=27;
        numeros[5]=65;
        numeros[6]=12;
        numeros[7]=34;
        numeros[8]=25;
        numeros[9]=28;


        for (int j=0;j<numeros.Length;j++){
            if(numeros[j]%2==0){
                Debug.Log("numero " + numeros[j] + " es par y se encuentra en la posicion " + j);
                par = true;
            }
        }

        if (!par){
            Debug.Log("No se han encontrado numeros pares");
        }        

    }

    // Update is called once per frame
     void Update() 
     {
        
     }
    
}

