using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoisesCDFEjercicio13 : MonoBehaviour
{
    // Start is called before the first frame update

    public string regalo;

    void Start()
    {
        

        switch (regalo){
            case "lunes":
                Debug.Log("El regalo de hoy es una panacota");
                break;
            case "martes":
                Debug.Log("El regalo de hoy es mousse de chocolate");
                break;
            case "miercoles":
                Debug.Log("El regalo de hoy es piña");
                break;
            case "jueves":
                Debug.Log("El regalo de hoy es manzana asada");
                break;
            case "viernes":
                Debug.Log("El regalo de hoy es tarta de queso");
                break;
            case "sabado":
                Debug.Log("El regalo de hoy es bizcocho");
                break;
            case "domingo":
                Debug.Log("El regalo de hoy es gelatina");
                break;
            default:
                Debug.Log("No hay regalo");
                break;                      
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
