using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Addition : MonoBehaviour
{
    // zona de propiedades
    public int inputNumber;

    // Start is called before the first frame update
    void Start()
    {
        // llamo a la funcion
        ShowSum(inputNumber);
    }

    // Update is called once per frame
    void ShowSum(int number)
    {
        int sum = 0;

        for (int i = 1; i <= number; i++)
        {
            sum += i;
        }

        Debug.Log("La suma de los numeros del 1 al " + number + " es: " + sum); // imprimo por consola
    }
}