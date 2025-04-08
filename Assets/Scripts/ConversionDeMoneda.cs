using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConversionDeMoneda : MonoBehaviour
{
    public float montoAConvertir;
    public string codigoMoneda;
    float cotizacionMoneda;
    float montoConvertido;
    float cotizacionEuro= 1541.11f;
    float cotizacionDolar= 1204.35f;
    float cotizacionReal= 201.24f;
    float minAConvertir = 1000;
    // Start is called before the first frame update
    void Start()
    {

        // paso 1
        if (montoAConvertir < minAConvertir)
        {
            Debug.Log("el monto minimo es 1000$");
            return;
        }
        if (codigoMoneda == "D")
        {
            cotizacionMoneda = cotizacionDolar;
        }else if (codigoMoneda == "E")
        {
            cotizacionMoneda = cotizacionEuro;
        }else if (codigoMoneda == "R")
        {
            cotizacionMoneda = cotizacionReal;
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
