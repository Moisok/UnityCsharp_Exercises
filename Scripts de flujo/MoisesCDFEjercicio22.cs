using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoisesCDFEjercicio22 : MonoBehaviour
{
    // Start is called before the first frame update

    public int nota = 0;

    void Start()
    {
        //Version if
        /*if (nota > 8 && nota <= 10){
            Debug.Log("Sobresaliente");
        }
        else if (nota > 6 && nota <= 8){
            Debug.Log("Notable");
        }
        else if (nota == 6){
            Debug.Log("Bien");
        }
        else if (nota == 5){
            Debug.Log("Aprobado");
        }
        else if (nota > 0 && nota <= 4){
            Debug.Log("Suspenso");
        }*/

        //Version Switch
        switch(nota){
            case 10:
                Debug.Log("Sobresaliente");
                break;
            case 9:
                Debug.Log("Sobresaliente");
                break;
            case 8:
                Debug.Log("Notable");
                break;
            case 7:
                Debug.Log("Notable");
                break;
            case 6:
                Debug.Log("Bien");
                break;
            case 5:
                Debug.Log("Aprobado");
                break;
            case 4:
                Debug.Log("Suspendido");
                break;
            case 3:
                Debug.Log("Suspendido");
                break;
            case 2:
                Debug.Log("Suspendido");
                break;
            case 1:
                Debug.Log("Suspendido");
                break;
            case 0:
                Debug.Log("Suspendido");
                break;                                        
            default:
                Debug.Log("No evaluado");
                break;                        
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
