using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FromSmallestToLargest : MonoBehaviour
{
    //zona propiedades

    public int numero1;
    public int numero2;
    public int numero3;

    // Start is called before the first frame update
    void Start()
    {

        // llamo al metodo
        ShowNumbersInOrder();

    }

    // llamar a la funcion
    void ShowNumbersInOrder()
    {
        
        int smallest, middle, largest;

        //comparacion de numeros
        if(numero1 <= numero2 && numero1 <numero3)
        {
             smallest = numero1;
            if (numero2 <= numero3)
            {
                middle = numero2;
                largest = numero3;
            }
            else
            {
                middle = numero3;
                largest = numero2;
            }
        }
        else if (numero2 <= numero1 && numero2 <= numero3)
        {
            smallest = numero2;
            if (numero1 <= numero3)
            {
                middle = numero1;
                largest = numero3;
            }
            else
            {
                middle = numero3;
                largest = numero1;
            }
        }
        else
        {
            smallest = numero3;
            if (numero1 <= numero2)
            {
                middle = numero1;
                largest = numero2;
            }
            else
            {
                middle = numero2;
                largest = numero1;
            }
        }

        // ver la secuencia ordenada
        Debug.Log("Los numeros de menor a mayor son:" + smallest + "," + middle + "," + largest );
    }
}