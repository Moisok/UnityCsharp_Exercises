using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoisesCDFEjercicio18 : MonoBehaviour
{
    // Start is called before the first frame update
    int contadorRegresivo = 20;
    void Start()
    {
        while (contadorRegresivo > 0){
            Debug.Log("Espere");
            contadorRegresivo = contadorRegresivo -2;
        }

        Debug.Log("Listo!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
