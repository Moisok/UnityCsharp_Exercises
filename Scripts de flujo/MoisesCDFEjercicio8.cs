using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoisesCDFEjercicio8 : MonoBehaviour
{
    // Start is called before the first frame update
    int valor1 = 15;
    void Start()
    {
        while (valor1 > 5){
            if (valor1%2!=0){
                Debug.Log(valor1 + " ");
            }
            valor1--;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
