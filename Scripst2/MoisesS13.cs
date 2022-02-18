using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoisesS13 : MonoBehaviour
{
    // Start is called before the first frame update
    List <persona> listado = new List<persona>(){
        new persona("87654334T","Perez","Manolo","Hombre",33,75),
        new persona("67654325W","Ramon","Joaquin","Hombre",16,55),
        new persona("58732169K","Garcia","Alba","Mujer",24,65),
        new persona("45869812H","Raposo","Alicia","Mujer",31,60),
        new persona("98765467U","Diaz","Alfonso","Hombre",38,120),
        new persona("28796542I","Porcar","Raul","Hombre",46,78),
        new persona("56789334R","Ulloa","Francisco","Hombre",55,90),
        new persona("87965412P","Ramirez","Paula","Mujer",30,110),
        new persona("98745698J","Rebollar","Natalia","Mujer",32,70),
        new persona("98756673L","Heredia","Maria","Mujer",23,60)  
    };

    public string busquedadni = " ";
    public int borrar;
    void Start()
    {
        //Buscar persona por DNI
        foreach(persona per in listado){
            if (busquedadni == per.dni){
                Debug.Log(per.personaToString());
            }
        }

        //Eliminar persona
        if (borrar <= 10 && borrar >= 0){
            listado.RemoveAt(borrar);
            Debug.Log("Se ha borrado el componente: "  + borrar);
        }else{
            Debug.Log("No hay tantos componentes");
        }
        
        //Ordenar por apellido
        listado.Sort((per1, per2) => per1.apellido.CompareTo(per2.apellido));
        foreach(persona per in listado){
            Debug.Log(per.personaToString());
        }

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

class persona {

    public string dni;
    public string apellido;
    public string nombre;
    public string sexo;
    public int edad;
    public int peso;

    public persona (string dni, string apellido, string nombre, string sexo, int edad, int peso){
        this.dni=dni;
        this.apellido=apellido;
        this.nombre=nombre;
        this.sexo=sexo;
        this.edad=edad;
        this.peso=peso;
    }

    public string personaToString (){
        return "Se llama " + nombre + " " + apellido + " su dni es " + dni + " es " + sexo + " tiene " + edad + " y pesa " + peso;
    }

    public string getDni(){
        return dni;
    }

}
