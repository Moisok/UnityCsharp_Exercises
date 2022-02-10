using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoisesCDFEjercicio14 : MonoBehaviour
{
    // Start is called before the first frame update

    int contador = 0;

    void Start()
    {
        while (contador <= 300){
            if (contador%3==0){
                Debug.Log(contador);
            }
            if (contador%5==0){
                Debug.Log(contador);
            }
            contador++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
