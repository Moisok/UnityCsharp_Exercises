using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoisesCDFEjercicio16 : MonoBehaviour
{
    // Start is called before the first frame update

    public double divisor;

    public double dividendo;

    void Start()
    {
        if (divisor == 0){
            Debug.Log("No se puede dividir entre 0");
        }else{
            Debug.Log("Resultado:  " + (divisor/dividendo) + "\nResto: " + (divisor%dividendo));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
