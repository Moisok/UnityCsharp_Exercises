using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoisesS11 : MonoBehaviour
{
    // Start is called before the first frame update
    string frase = " ";

    string [] cadenas = new string [3];
    
    void Start()
    {

        cadenas [0] = "Hazlo";
        cadenas [1] = " o no lo hagas,";
        cadenas [2] = " pero no lo intentes.";

        for (int i=0;i<cadenas.Length;i++){
            frase = frase + cadenas[i];
        }

        Debug.Log(frase);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
