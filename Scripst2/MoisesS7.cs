using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoisesS7 : MonoBehaviour
{
    // Start is called before the first frame update

    double[] numeros = new double [10];

    int Ndatos = 1;
    double datos = 0;

    double suma;
    double media;
    void Start()
    {
        double maximo = numeros[0];

        double minimo = numeros [0];
          //Array donde se generaras 10 numeros de forma aleatoria
        for (int i=0;i<10;i++){
            numeros[i] = Ndatos;
            Debug.Log("Generado...: " + Ndatos);
            Ndatos++;
        }

        for(int i=0;i<10;i++){
            datos++;
            suma = suma + numeros[i];
            if (numeros[i]>maximo){
                maximo = numeros[i];
            }
            if (numeros[i]<minimo){
                minimo=numeros[i];
            }
            
        }
         
            Debug.Log("Numero de datos: " + datos);
            Debug.Log("Suma de los datos: " + suma);
            Debug.Log("Maximo numero: " + maximo);
            Debug.Log("Minimo numero: " + minimo);
            Debug.Log("Media: " + suma/10);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
