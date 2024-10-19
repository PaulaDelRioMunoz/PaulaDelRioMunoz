using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplesOfThreeTwo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // llamo a la funcion
        ShowMultiplesOfThreeTwoNumbers();
    }

    // Update is called once per frame
    void ShowMultiplesOfThreeTwoNumbers()
    {
        Debug.Log("Multiplos de 3 y 2 entre el 0 y el 100:"); // imprimo por consola los multiplos de 3 y 2
        for (int i = 0; i <= 100; i++)
        {
            if (i % 3 == 0)
            {
                if (i % 2 == 0)
                {
                    Debug.Log(i);
                }
            }
        }
    }
}
