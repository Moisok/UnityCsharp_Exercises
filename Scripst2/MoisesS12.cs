using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoisesS12 : MonoBehaviour
{
    // Start is called before the first frame update
    string [] cuenta = new string [10];
    string [] cuentainversa = new string [10];
    
    int copia = 0;
    void Start()
    {
        cuenta[0]="uno";
        cuenta[1]="dos";
        cuenta[2]="tres";
        cuenta[3]="cuatro";
        cuenta[4]="cinco";
        cuenta[5]="seis";
        cuenta[6]="siete";
        cuenta[7]="ocho";
        cuenta[8]="nueve";
        cuenta[9]="diez";

        for (int i=9;i>-1;i--){
            cuentainversa[i] = cuenta[copia];
            copia++;
        }

        for (int i=0;i<cuentainversa.Length;i++){
            Debug.Log(cuentainversa[i]);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
