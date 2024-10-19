using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplesOfThree : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // llamo a la funcion
        ShowMultiplesOfThreeNumbers();
    }

    // Update is called once per frame
    void ShowMultiplesOfThreeNumbers()
    {
        Debug.Log("Multiplos de 3 entre el 0 y el 100:"); // imprimo por consola los multiplos de 3
        for (int i = 0; i <= 100; i++)
        {
           
            if (i % 3 == 0)
            {
                Debug.Log(i);
            }
        }
    }
}
