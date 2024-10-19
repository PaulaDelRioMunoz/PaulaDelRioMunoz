using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Month : MonoBehaviour
{
    //zona de variables
    public int month;

    // Start is called before the first frame update
    void Start()
    {
        
        // llamo al metodo
        Months();

    }


    // metodo
    void Months()
    {
        switch (month)
        {
            case 1:
            Debug.Log("El 1º mes es Enero");
            break;
            case 2:
            Debug.Log("El 2º mes es Febrero");
            break;
            case 3:
            Debug.Log("El 3º mes es Marzo");
            break;
            case 4:
            Debug.Log("El 4º mes es Abril");
            break;
            case 5:
            Debug.Log("El 5º mes es Mayo");
            break;
            case 6:
            Debug.Log("El 6º mes es Junio");
            break;
            case 7:
            Debug.Log("El 7º mes es Julio");
            break;
            case 8:
            Debug.Log("El 8º mes es Agosto");
            break;
            case 9:
            Debug.Log("El 9º mes es Septiembre");
            break;
            case 10:
            Debug.Log("El 10º mes es Octubre");
            break;
            case 11:
            Debug.Log("El 11º mes es Noviembre");
            break;
            case 12:
            Debug.Log("El 12º mes es Diciembre");
            break;
            default:
            Debug.Log("Este numero no corresponde con ningun mes"); // Imprime por consola
            break;

        }
    }
}
