using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Huevos : MonoBehaviour
{
    // Variables
    public GameObject Huevo;
    public Transform PosRotHuevo;
    private float thrustY = 100.0f,
                thrustZ = 300.0f,
                timeHuevo = 5.0f;

    // Update is called once per frame
    void Update()
    {
        CreateHuevos();
    }

    private void CreateHuevos()
    {
        if (Input.GetMouseButtonDown(0))
        {

            GameObject cloneHuevo = Instantiate(Huevo, PosRotHuevo.position, PosRotHuevo.rotation);

            //Destruir huevos despues de 5 segundos
            Destroy(cloneHuevo, timeHuevo);
        }
    }
}
