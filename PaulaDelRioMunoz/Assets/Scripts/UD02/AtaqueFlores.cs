using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtaqueFlores : MonoBehaviour
{
    // Variables
    public GameObject Flor;
    public Transform PosRotFlor;
    private float thrustY = 100.0f,
                thrustZ = 300.0f,
                timeFlor = 5.0f;

    // Update is called once per frame
    void Update()
    {
        CreateFlores();
    }

    private void CreateFlores()
    {
        if (Input.GetMouseButtonDown(0))
        {

            GameObject cloneFlor = Instantiate(Flor, PosRotFlor.position, PosRotFlor.rotation);

            //El componente "rigidbody" es el de los clones
            Rigidbody rbFlor = cloneFlor.GetComponent<Rigidbody>();

            //"Vector3" para referir al eje Y
            rbFlor.AddForce(Vector3.up * thrustY);
            //"transform.forward" para referir al eje Z
            rbFlor.AddForce(transform.forward * thrustZ);

            //Destruir Flores despues de 5 segundos
            Destroy(cloneFlor, timeFlor);
        }
    }
}
