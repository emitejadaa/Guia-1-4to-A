using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatosDelUsuario : MonoBehaviour
{
    public string nombreUsuario;
    [SerializeField] int edadUsuario;
    public float estaturaUsuario;
    public bool donanteOrganos;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Mi nombre es " + nombreUsuario + ", tengo " + edadUsuario + ", mido " + estaturaUsuario + " metros y es " + donanteOrganos + " que soy donante de órganos.");
    }

    // Update is called once per frame
    void Update()
    {
        

    }
}
