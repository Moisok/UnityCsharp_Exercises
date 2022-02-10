using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoisesCDFEjercicio12 : MonoBehaviour
{
    // Start is called before the first frame update
    public int Marcador;

    const int nextLvl = 5000;

    void Start()
    {
        if (Marcador < nextLvl){
            Debug.Log("Te faltan puntos" + "("+nextLvl+"), tienes: " + Marcador);
        }else{
            Debug.Log("Felicidades pasas al siguiente nivel!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
