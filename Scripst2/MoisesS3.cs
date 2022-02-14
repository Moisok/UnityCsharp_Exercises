using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoisesS3 : MonoBehaviour
{
    // Start is called before the first frame update

    List <int> numeros = new List<int>();

    public int buscar;

    void Start()
    {

        for (int i = 0; i < 10; i++)
        {
            numeros.Add(i);
        }

        if (numeros.Contains(buscar))
        {
            Debug.Log("El numero: " + buscar + " se encuentra en la posicion [" + numeros.IndexOf(buscar) + "]");
        }
        else
        {
            Debug.Log("No existe el numero");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
