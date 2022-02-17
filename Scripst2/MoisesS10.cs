using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoisesS10 : MonoBehaviour
{
    // Start is called before the first frame update

   List <Alumno> infoAlumno = new List <Alumno>();
    void Start()
    {
        infoAlumno.Add(new Alumno("Joan",5));
        infoAlumno.Add(new Alumno("Zaira",7));
        infoAlumno.Add(new Alumno("Zorman",4));
        infoAlumno.Add(new Alumno("Xavier",3));
        infoAlumno.Add(new Alumno("Anita",10));
        infoAlumno.Add(new Alumno("Ramon",7));
        infoAlumno.Add(new Alumno("Adrian",9));
        infoAlumno.Add(new Alumno("Ismael",10));
        infoAlumno.Add(new Alumno("Paco",5));
        infoAlumno.Add(new Alumno("Estefania",8));
        infoAlumno.Add(new Alumno("Ramona",2));
        infoAlumno.Add(new Alumno("Nelia",5));
        infoAlumno.Add(new Alumno("Natalia",7));
        infoAlumno.Add(new Alumno("Rocio",8));
        infoAlumno.Add(new Alumno("Alfonso",5));

        infoAlumno.Sort((alu1, alu2) => alu1.nombre.CompareTo(alu2.nombre));

        foreach (Alumno alum in infoAlumno){
            Debug.Log(alum.nombre + " tiene de nota " + alum.nota);
        }

        Debug.Log("Ahora comparamos por nota\n");

        infoAlumno.Sort((alu1, alu2) => alu1.nota.CompareTo(alu2.nota));
        foreach (Alumno alum in infoAlumno){
            Debug.Log(alum.nombre + " tiene de nota " + alum.nota);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

class Alumno{
    public string nombre;
    public int nota;

    public Alumno(string nombre, int nota){

        this.nombre= nombre;

        this.nota= nota;

    }
}