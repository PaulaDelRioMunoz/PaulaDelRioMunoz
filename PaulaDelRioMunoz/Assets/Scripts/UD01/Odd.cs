using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Odd : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // llamo a la funcion
        ShowOddNumbers();
    }

    // Update is called once per frame
    void ShowOddNumbers()
    {
        Debug.Log("Numeros impares entre 0 y 100:");
        for (int i = 0; i <= 100; i++)
        {
            // Si el numero es impar se mostrara
            if (i % 2 != 0)
            {
                Debug.Log(i);
            }
        }
    }
}