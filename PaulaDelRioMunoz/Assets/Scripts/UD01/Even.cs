using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Even : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // llamo a la funcion
        ShowEvenNumbers();
    }

    // Update is called once per frame
    void ShowEvenNumbers()
    {
        Debug.Log("Numeros pares entre 0 y 100:");
        for (int i = 0; i <= 100; i++)
        {
            // Si el numero es par se mostrara
            if (i % 2 == 0)
            {
                Debug.Log(i);
            }
        }
    }
}
