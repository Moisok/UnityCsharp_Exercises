using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoisesCDFEjercicio11 : MonoBehaviour
{
    // Start is called before the first frame update
    public bool bronce = false;

    public bool plata = false;

    public bool oro = false;

    void Start()
    {
        if (bronce == true && !plata && !oro){
            Debug.Log("Tienes la llave de bronze, te faltan 2 mas");
        }
        if(plata == true && !oro && !bronce){
            Debug.Log("Tienes la llave de plata, te faltan 2 mas");
        }
        if(oro == true && !plata && !bronce){
            Debug.Log("Tienes la llave de oro, te faltan 2 mas");
        }
        else if(bronce == true && plata == true && !oro){
            Debug.Log("Tienes la llave de bronce y plata, te faltan 1 mas");
        }
        else if(bronce == true && oro == true && !plata){
            Debug.Log("Tienes la llave de bronce y oro, te faltan 1 mas");
        }
        else if(plata == true && oro == true && !bronce){
            Debug.Log("Tienes la llave de plata y oro, te faltan 1 mas");
        }else{
            Debug.Log("Felicidades, tienes todas las llaves has desbloqueado el nivel secreto!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
