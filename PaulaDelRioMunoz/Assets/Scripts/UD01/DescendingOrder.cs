using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DescendingOrder : MonoBehaviour
{
    // zona propiedades

    public int numero1;
    public int numero2;
    public int numero3;

    // Start is called before the first frame update
    void Start()
    {
        // llamo al metodo
        CheckDescendingOrder();
    }

    // Update is called once per frame
    void CheckDescendingOrder()
    {
        // compara los numeros e imprime el resultado
        if (numero1 > numero2 && numero2 > numero3)
        {
            Debug.Log("Los numeros estan en orden decreciente.");

        }
        else 
        {
            Debug.Log("los numeros no estan en orden decreciente");
        }
    }
}
