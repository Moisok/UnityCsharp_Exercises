using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoisesS9 : MonoBehaviour
{
    // Start is called before the first frame update
    // Start is called before the first frame update
    List <string> nombres = new List <string> {"Bartolo","Alfonso","Rafita","Joan","Anita"};
    List <int> saldos = new List <int> {18000,22000,32000,670000,11000};
  
    void Start()
    {
        int mayor = saldos[1];
        
        string nombre = " ";

        for(int i=0; i<5; i++){
            if (saldos[i]>mayor){
                mayor = saldos[i];
                nombre = nombres[i];
            }
        }

        Debug.Log(nombre + " tiene " + mayor + " y es quien mas dinero cobra");
        
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
