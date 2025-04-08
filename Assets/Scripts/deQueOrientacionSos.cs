using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deQueOrientacionSos : MonoBehaviour
{
    public string nombreAlumno;
    public int añoAlumno;
    public string especialidadAlumno;
    string tic = "T";
    string medios = "M";
    string gestion = "G";
    string diseno = "D";
    string humanidades = "H";
    int minAño = 1;
    int minAñoEspecialidad = 3;
    int maxAño = 5;

    // Start is called before the first frame update
    void Start()
    {
        if (nombreAlumno == "" || nombreAlumno==" ")
        {
            Debug.Log("el campo nombre alumno no puede estar vacio");
            return;
        }
        if(añoAlumno>maxAño || añoAlumno < minAño)
        {
            Debug.Log("año no valido");
            return;
        }

        if (añoAlumno < minAñoEspecialidad){
            Debug.Log("Error. Aún estás en el ciclo básico");
            return;
        }
        if (especialidadAlumno != tic || especialidadAlumno != medios || especialidadAlumno != gestion || especialidadAlumno != diseno || especialidadAlumno != humanidades)
        {
            Debug.Log("Solo puede ingresar T, D, G, M o H");
            return;
        }

        Debug.Log("Muchas gracias " + nombreAlumno + "!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
