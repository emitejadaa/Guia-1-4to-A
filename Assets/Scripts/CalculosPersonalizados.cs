using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalculosPersonalizados : MonoBehaviour
{
    public float num1;
    public float num2;
    float resultado;
    // Start is called before the first frame update
    void Start()
    {
        resultado = num1 + num2;
        Debug.Log("la suma entre "+num1+" y "+num2+" da: " + resultado);
        resultado = num1 * num2;
        Debug.Log("la multiplicacion entre " + num1 + " y " + num2 + " da: " + resultado);
        resultado = num1 - num2;
        Debug.Log("la resta entre " + num1 + " y " + num2 + " da: " + resultado);
        resultado = num1 / num2;
        Debug.Log("la division entre " + num1 + " y " + num2 + " da: " + resultado);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
