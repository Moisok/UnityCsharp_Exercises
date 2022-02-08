using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoisesEjercicio12 : MonoBehaviour
{
    // Start is called before the first frame update
    public double grados;
    void Start()
    {
        Debug.Log("Grados: " + grados);
        Debug.Log("Kelvin: " + (grados+273));
        Debug.Log("Farenheit: " + ((grados*18)/10+32));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
