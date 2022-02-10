using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoisesCDFEjercicio21 : MonoBehaviour
{
    // Start is called before the first frame update
    public int valorAbsoluto;

    void Start()
    {
        if (valorAbsoluto<0){
            valorAbsoluto = valorAbsoluto * -1;
        }

        Debug.Log("El valor absoluto es: " + valorAbsoluto);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
