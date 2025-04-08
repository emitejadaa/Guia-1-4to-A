using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConversionDeMoneda : MonoBehaviour
{
    public float montoAConvertir;
    public string codigoMoneda;
    float cotizacionMoneda;
    float montoConvertido;
    // Start is called before the first frame update
    void Start()
    {

        // paso 1
        if (montoAConvertir < 1000)
        {
            Debug.Log("el monto minimo es 1000");
            return;
        }
        if (codigoMoneda == "D")
        {
            cotizacionMoneda = 1204.35f;
        }else if (codigoMoneda == "E")
        {
            cotizacionMoneda = 1541.11f;
        }else if (codigoMoneda == "R")
        {
            cotizacionMoneda = 201.24f;
        }
        else
        {
            Debug.Log("el codigo de moneda es invalido");
            return;
        }
        // paso 2
        montoConvertido = montoAConvertir / cotizacionMoneda;
        // paso 3
        Debug.Log("monto convertido: "+montoConvertido);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
