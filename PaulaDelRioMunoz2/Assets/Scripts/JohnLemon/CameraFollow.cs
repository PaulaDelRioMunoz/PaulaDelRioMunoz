using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    //Variables
    public Transform Target;
    [Header("Vectors")]
    //Velocidad seguimiento cámara
    [SerializeField]
    private float _smoothing;
    //Distancia inicial entre cámara y personaje
    [SerializeField]
    private Vector3 _offset;

    // Start is called before the first frame update
    void Start()
    {
        
        _offset = transform.position - Target.position;

    }

    private void LateUpdate()
    {

        //Posicion a la que queremos mover la cámara
        Vector3 desiredPosition = Target.position + _offset;

        //Movemos la cámara
        transform.position = Vector3.Lerp(transform.position, desiredPosition, _smoothing * Time.deltaTime);

    }

    
}
