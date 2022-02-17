using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoisesS8 : MonoBehaviour
{   
    // Start is called before the first frame update
    List <string> nombres = new List <string> {"Bartolo","Alfonso","Rafita","Joan","Anita"};
    List <int> edades = new List <int> {18,15,32,67,11};
    

    void Start()
    {
        for(int i=0; i<5; i++){
            if (edades[i]>=18){
                Debug.Log(nombres[i] + " tiene " + edades[i] + " por lo que es mayor de edad");
            }
        }

        
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
