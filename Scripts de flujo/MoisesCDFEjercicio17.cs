using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoisesCDFEjercicio17 : MonoBehaviour
{
    // Start is called before the first frame update
    public int desde = 0;
    public int hasta = 0;

    
    
    void Start()
    {
        int contador = desde;
        
        for (int i=desde;i<hasta;i++){
            Debug.Log(i);
        }

        while (contador < hasta){
            Debug.Log(contador);
            contador++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
